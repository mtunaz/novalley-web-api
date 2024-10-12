using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
namespace Novalley_api_server.Models
{
    [PrimaryKey(nameof(UserID), nameof(NovelID))]
    public class FavoriteNovel
    {
        public int UserID { get; set; }
        public int NovelID { get; set; }

        // Navigation property
        public User User { get; set; } = null;
        public Novel Novel { get; set; } = null;
    }
}
