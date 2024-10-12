using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Novalley_api_server.Models;

namespace Novalley_api_server.Data
{
    public class NovalleyDbContext: IdentityDbContext<User, IdentityRole<int>, int>
    {
        public NovalleyDbContext(DbContextOptions<NovalleyDbContext> options) : base(options) { }

     
        public DbSet<Novel> Novels { get; set; }
        public DbSet<NovelChapter> NovelChapters { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FavoriteNovel> FavoriteNovels { get;set; }
        public DbSet<NovelRating> NovelRatings { get; set; }
        public DbSet<NovelTag> NovelTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserCurrentChapter> UserCurrentChapters { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }

    }
}
