using Ecommerce.Entities;

namespace Ecommerce.Repository.Interfaces;

public interface IUserRepository
{
    public void AddUser(User user);
    public Task<User?> GetUserByEmail(string email);
}