using JWT_WebAPICoreSix.Models;
using JWT_WebAPICoreSix.Request_Models;

namespace JWT_WebAPICoreSix.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginreq);
    }
}
