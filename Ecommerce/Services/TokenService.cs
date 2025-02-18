using Ecommerce.Model;
using Ecommerce.Services.Interfaces;

namespace Ecommerce.Services;

public class TokenService : ITokenService
{
    public readonly IConfiguration _configuration;

    public string GenerateToken(User user)
    {
        throw new NotImplementedException();
    }
}