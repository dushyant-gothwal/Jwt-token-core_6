using JWT_WebAPICoreSix.Interfaces;
using JWT_WebAPICoreSix.Models;
using JWT_WebAPICoreSix.Request_Models;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace JWT_WebAPICoreSix.Services
{
    public class AuthService : IAuthService
    {
        private readonly JwtContext _jwtContext;
        private readonly IConfiguration _configuration;
        public AuthService(JwtContext jwtContext , IConfiguration configuration) { 
          
            _jwtContext = jwtContext;
            _configuration = configuration; 
        }
        public User AddUser(User user)
        {
            var addedUser = _jwtContext.Users.Add(user);
            _jwtContext.SaveChanges();
            return addedUser.Entity;
        }

        public string Login(LoginRequest loginreq)
        {
            if (loginreq.Username != null && loginreq.Password != null)
            {
                var user = _jwtContext.Users.SingleOrDefault(s => s.Email == loginreq.Username && s.Password == loginreq.Password);
                if (user != null)
                {
                    //var claims = new[] {
                    //    new Claim("Subject", _configuration["Jwt:Subject"]),
                    //    new Claim("Id",user.Id.ToString()),
                    //    new Claim("UserName",user.Name),
                    //    new Claim("Email",user.Email)
                    //};

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        null,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);
                    return new JwtSecurityTokenHandler().WriteToken(token);
                    

                }
                else
                {
                    throw new Exception("User is not valid");
                }
            }
            else 
            {
                throw new Exception("Credentials are not valid");
            }
        }
    }
}
