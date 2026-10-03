using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace Profilecustomization_Ex.Data;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }
    public string ProfilePicPath { get; set; } = "/images/default-profile.png";
    [NotMapped]
    public IFormFile? Pic { get; set; }

}
