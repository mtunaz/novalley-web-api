using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novalley_api_server.Models
{
    [PrimaryKey(nameof(NovelID), nameof(UserID))]
    public class NovelRating
    {
        public int NovelID { get; set; }
        public int UserID { get; set; }
        public int UserRating {  get; set; }

        // Navigation property
        public User User { get; set; } = null;
        public Novel Novel { get; set; } = null;
    }
}
