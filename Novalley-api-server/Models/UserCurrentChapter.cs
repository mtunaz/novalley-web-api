using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Novalley_api_server.Models
{
    [PrimaryKey(nameof(UserID), nameof(NovelID))]
    public class UserCurrentChapter
    {
        public int UserID { get; set; }
        public int NovelID {  get; set; }
        public int ChapterID { get; set; }

        // Navigation property
        public User User { get; set; } = null;
        public NovelChapter NovelChapter { get; set; } = null;
    }
}
