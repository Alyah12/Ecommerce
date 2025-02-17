using Ecommerce.Context;
using Ecommerce.DTO;
using Ecommerce.Model;
using Ecommerce.Repository.Interfaces;

namespace Ecommerce.Repository;

public class UserRepository : IUserRepository
{
    readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddUser(User user)
    {
        using (var transaction = _context)
        {
          transaction.User.AddAsync(user);
          transaction.SaveChangesAsync();
        }
    }

    public User? GetUserByEmail(string email)
    {
        using (var transaction = _context)
        {
            var user = transaction.User.FirstOrDefault(u => u.Email == email);
            return user;
        }
    }
}