using ClientLibrary.Models;
using ClientLibrary.Models.Authentication;
namespace ClientLibrary.Services
{
    public interface IAuthenticationService
    {
        Task<ServiceResponse> CreateUser(CreateUser user);
        Task<LoginReponse> LoginUser(CreateUser user);
        Task<LoginReponse> ReviveToken(string refreshToken);
    }
}
