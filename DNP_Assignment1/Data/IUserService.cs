using Models;

namespace DNP_Assignment1.Data
{
    public interface IUserService
    {
        User ValidateUser(string email, string password);
    }
}