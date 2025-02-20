using Ecommerce.Model;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Services.Interfaces;

namespace Ecommerce.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository) =>
        _userRepository = userRepository;

    public void AddUser(User user) =>
        _userRepository.AddUser(user);


    public User? GetUserByEmail(string email) =>
        _userRepository.GetUserByEmail(email).Result;

}