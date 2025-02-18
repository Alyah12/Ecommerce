using Ecommerce.Context;
using Ecommerce.DTO;
using Ecommerce.Model;
using Ecommerce.Repository.Interfaces;
using Microsoft.Data.SqlClient;

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
        try
        {
            using (var transaction = _context)
            {
                transaction.User.AddAsync(user);
                transaction.SaveChangesAsync();
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine("O programa apresentou o seguinte erro: " + e);
            Console.WriteLine(e.SqlState);
        }
    }

    public User? GetUserByEmail(string email)
    {
        try
        {
            using (var transaction = _context)
            {
                var user = transaction.User.FirstOrDefault(u => u.Email == email);
                return user;
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine("O programa apresentou o seguinte erro: " + e);
            Console.WriteLine(e.SqlState);
        }

        return null;
    }
}