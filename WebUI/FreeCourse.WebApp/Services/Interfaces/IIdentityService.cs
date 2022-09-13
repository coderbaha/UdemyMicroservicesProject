using FreeCourse.Shared.Dtos;
using FreeCourse.WebApp.Models;
using IdentityModel.Client;
using System.Threading.Tasks;

namespace FreeCourse.WebApp.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn(SignInInput signinInput);

        Task<TokenResponse> GetAccessTokenByRefreshToken();

        Task RevokeRefreshToken();
    }
}