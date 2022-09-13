using FreeCourse.WebApp.Models;
using System.Threading.Tasks;

namespace FreeCourse.WebApp.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}