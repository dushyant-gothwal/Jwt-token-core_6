using JWT_WebAPICoreSix.Interfaces;
using JWT_WebAPICoreSix.Models;
using JWT_WebAPICoreSix.Request_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWT_WebAPICoreSix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }  

        // POST api/<AuthController>
        [AllowAnonymous]
        [HttpPost]
        public string Login([FromBody] LoginRequest value)
        {
            var result = _authService.Login(value);
            return result;
        }

        // PUT api/<AuthController>/5
        [HttpPost("addUser")]
        public User AddUser([FromBody] User value)
        {
            var user= _authService.AddUser(value);
            return  user;
        }

    }
}
