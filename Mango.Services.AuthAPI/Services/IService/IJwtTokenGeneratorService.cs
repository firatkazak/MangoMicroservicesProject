using Mango.Services.AuthAPI.Models.Model;

namespace Mango.Services.AuthAPI.Services.IService;

public interface IJwtTokenGeneratorService
{
    string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
}
