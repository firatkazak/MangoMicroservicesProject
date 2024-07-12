using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.Models.Model;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
}
