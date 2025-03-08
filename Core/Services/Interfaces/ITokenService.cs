using Ecommerce.Entities;

namespace Ecommerce.Services.Interfaces;

public interface ITokenService
{
    public string GenerateToken(User user);
}