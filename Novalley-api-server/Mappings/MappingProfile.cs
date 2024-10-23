using AutoMapper;
using System.Runtime.InteropServices;
using Novalley_api_server.DTOs;
using Novalley_api_server.Models;

namespace Novalley_api_server.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<NovelChapter, ChapterDto>();
            CreateMap<Comment,  CommentDto>();
        }
    }
}
