using Novalley_api_server.Models;
using Novalley_api_server.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Novalley_api_server.Data;
using Microsoft.EntityFrameworkCore;
using Novalley_api_server.DTOs;
using AutoMapper;

namespace Novalley_api_server.Services
{
    public class NovelService: INovelService
    {
        private readonly NovalleyDbContext _novalleyDbContext;
        private readonly IMapper _mapper;
        public NovelService(NovalleyDbContext novalleyDbContext, IMapper mapper) 
        {
            _novalleyDbContext = novalleyDbContext;
        }
        public async Task<List<Novel>> GetAllNovelsAsync()
        {
            var novels = await _novalleyDbContext.Novels.ToListAsync();

            return novels;
        }

        public async Task<Novel> GetNovelByIdAsync(int novelId)
        {

            var novel = await _novalleyDbContext.Novels
                .Where(novel => novel.NovelID == novelId)
                .FirstOrDefaultAsync();
            return novel;
        }

        public async Task<List<ChapterDto>> GetChaptersAsync(int novelId)
        {
            var chapters = await _novalleyDbContext.NovelChapters
                .Where(chapter => chapter.NovelID == novelId)
                .ToListAsync();
            var mappedChapters = _mapper.Map<List<ChapterDto>>(chapters);
            return mappedChapters;
        }

        public async Task<string> GetChapterContentAsync(int novelId, int chapterId)
        {
            var chapterContent = await _novalleyDbContext.NovelChapters
                .Where(_chapter => _chapter.NovelID == novelId && _chapter.ChapterID == chapterId)
                .Select(_chapter => _chapter.ChapterContent)
                .FirstOrDefaultAsync();
            return chapterContent;
        }

        public async Task<List<CommentDto>> GetCommentsAsync(int novelId, int chapterId)
        {
            var chapterComments = await _novalleyDbContext.Comments
                .Where(comment => comment.NovelId == novelId && comment.ChapterID == chapterId)
                .ToListAsync();
            var mappedComments = _mapper.Map<List<CommentDto>>(chapterComments);
            return mappedComments;
        }
    }
}
