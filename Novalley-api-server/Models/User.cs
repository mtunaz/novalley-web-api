using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Novalley_api_server.Models
{
    public class User: IdentityUser<int>
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string AvartarURL { get; set; } = string.Empty;
    }
}
