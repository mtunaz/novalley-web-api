using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Novalley_api_server.Models
{
    //Need Identity
    public class User: IdentityUser<int>
    {
        [Key]
        public int UserID {  get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string AvartarURL { get; set; } = string.Empty;
    }
}
