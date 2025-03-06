using Ecommerce.Context;
using Ecommerce.Entities;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Services.Interfaces;

namespace Ecommerce.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly AppDbContext _context;

    public UserService(IUserRepository userRepository, AppDbContext context)
    {
        _userRepository = userRepository;
        _context = context;
    }

    public void AddUser(User user)
    {
        _userRepository.AddUser(user);
    }

    public User? GetUserByEmail(string email)
    {
        if (email is Validators.UserValidator)
        {
            return _userRepository.GetUserByEmail(email).Result;
        }

        return null;
    }

}