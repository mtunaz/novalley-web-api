using System.ComponentModel.DataAnnotations;

namespace Novalley_api_server.Models
{
    public class Novel
    {
        [Key]
        public int NovelID { get; set; }

        public string? NovelTitle { get; set;}

        public int AuthorID { get; set; }

        public string? CoverURL { get; set; }

        // Navigation property
        public User User { get; set; } = null;
        public ICollection<NovelChapter> NovelChapters { get; set; } = new List<NovelChapter>();

    }
}
