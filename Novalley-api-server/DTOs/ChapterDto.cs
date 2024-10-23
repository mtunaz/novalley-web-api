namespace Novalley_api_server.DTOs
{
    public class ChapterDto
    {
        public int ChapterID { get; set; }

        public int NovelID { get; set; }

        public string? ChapterTitle { get; set; }

        public DateTime UploadTime { get; set; }
    }
}
