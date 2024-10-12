using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novalley_api_server.Models
{
    
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        public int UserID { get; set; }

        public int NovelId { get; set; }

        public int ChapterID { get; set; }

        public DateTime CommentDateTime {  get; set; }

        public string CommentText { get; set; } = string.Empty;

        // Navigation property
        public User User { get; set; } = null;
        public NovelChapter NovelChapter { get; set; } = null;

    }
}
