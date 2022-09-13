using System;
using System.Threading.Tasks;

namespace FreeCourse.WebApp.Services.Interfaces
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();
    }
}