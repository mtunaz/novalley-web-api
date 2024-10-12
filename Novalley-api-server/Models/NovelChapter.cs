using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Novalley_api_server.Models
{
    [PrimaryKey(nameof(ChapterID), nameof(NovelID))]
    public class NovelChapter
    {
        public int ChapterID { get; set; }

        public int NovelID { get; set; }

        public string? ChapterTitle { get; set; }

        public DateTime UploadTime { get; set; }

        public string ChapterContent { get; set; } = string.Empty;

        // Navigation property
        public Novel Novel { get; set; } = null;
    }
}
