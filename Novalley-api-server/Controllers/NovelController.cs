using Microsoft.AspNetCore.Mvc;
using Novalley_api_server.Interfaces;
using Novalley_api_server.Services;

namespace Novalley_api_server.Controllers
{
    [ApiController]
    [Route("api/novel")]
    public class NovelController: ControllerBase
    {
        private readonly INovelService novelService;
        public NovelController(INovelService _novelService) 
        {
            novelService = _novelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNovelAsync()
        {
            try
            {
                var novels = await novelService.GetAllNovelsAsync();
                return Ok(novels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
         
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNovelByIdAsync(int novelId)
        {
            try
            {
                var novel = await novelService.GetNovelByIdAsync(novelId);
                return Ok(novel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{novelId}/{chapterId}/comment")]
        public async Task<IActionResult> GetCommentsAsync(int novelId, int chapterId)
        {
            try
            {
                var comments = await novelService.GetCommentsAsync(novelId, chapterId);
                return Ok(comments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet("{novelId}/{chapterId}/content")]
        public async Task<IActionResult> GetChapterContentAsync(int novelId, int chapterId)
        {
            try
            {
                var chapterContent = await novelService.GetChapterContentAsync(novelId, chapterId);
                return Ok(chapterContent);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{novelId}/chapters")]
        public async Task<IActionResult> GetNovelChaptersAsync(int novelId)
        {
            try
            {
                var chapters = await novelService.GetChaptersAsync(novelId);
                return Ok(chapters);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
