using Ecommerce.Model;

namespace Ecommerce.Services.Interfaces;

public interface IUserService
{
    public void AddUser(User user);
    public User? GetUserByEmail(string email);
}