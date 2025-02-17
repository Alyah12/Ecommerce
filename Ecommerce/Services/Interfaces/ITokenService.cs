using Ecommerce.Model;

namespace Ecommerce.Services.Interfaces;

public interface ITokenService
{
    public string GenerateToken(User user);
}