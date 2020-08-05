using System.Threading.Tasks;
using ekeneEstateApp.Data.Entities;
using ekeneEstateApp.Web.Models;

namespace ekeneEstateApp.Web.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}