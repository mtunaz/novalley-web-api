using Novalley_api_server.Models;
using Novalley_api_server.DTOs;

namespace Novalley_api_server.Interfaces
{
    public interface INovelService
    {
        public Task<List<Novel>> GetAllNovelsAsync();
        public Task<Novel> GetNovelByIdAsync(int novelID);
        public Task<List<ChapterDto>> GetChaptersAsync(int novelId);
        public Task<string> GetChapterContentAsync(int novelId, int chapterId);
        public Task<List<CommentDto>> GetCommentsAsync(int novelId, int chapterId);
    }
}
