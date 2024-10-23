namespace Novalley_api_server.DTOs
{
    public class CommentDto
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public int NovelId { get; set; }
        public int ChapterID { get; set; }
        public DateTime CommentDateTime { get; set; }
        public string CommentText { get; set; } = string.Empty;
    }
}
