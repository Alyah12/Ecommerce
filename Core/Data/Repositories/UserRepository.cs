using Ecommerce.Context;
using Ecommerce.DTO;
using Ecommerce.Entities;
using Ecommerce.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository;

public class UserRepository : IUserRepository
{
   public readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddUser(User user)
    {
        _context.User.AddAsync(user);
        _context.SaveChangesAsync();
    }

    public Task <User?> GetUserByEmail(string email) =>
    _context.User.FirstOrDefaultAsync(u => u.Email == email);
}