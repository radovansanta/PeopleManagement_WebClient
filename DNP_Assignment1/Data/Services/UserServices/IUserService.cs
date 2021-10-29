using System.Threading.Tasks;
using Models;

namespace DNP_Assignment1.Data.Services.UserServices
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string email, string password);
        Task AddUserAsync(User user);
    }
}