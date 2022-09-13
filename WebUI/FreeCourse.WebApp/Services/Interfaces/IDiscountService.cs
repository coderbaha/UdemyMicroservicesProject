using FreeCourse.WebApp.Models.Discounts;
using System.Threading.Tasks;

namespace FreeCourse.WebApp.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<DiscountViewModel> GetDiscount(string discountCode);
    }
}