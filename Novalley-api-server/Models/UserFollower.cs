using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Novalley_api_server.Models
{
    [PrimaryKey(nameof(UserID), nameof(UserFollowerID))]
    public class UserFollower
    {
        public int UserID { get; set; }
        public int UserFollowerID { get; set;}

        // Navigation 
        public User User { get; set; } = null;
        public ICollection<User> Followers {  get; set; } = new List<User>();
    }
}
