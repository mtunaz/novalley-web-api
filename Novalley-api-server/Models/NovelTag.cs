using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novalley_api_server.Models
{
    [PrimaryKey(nameof(NovelID), nameof(TagID))]
    public class NovelTag
    {
        public int NovelID { get; set; }

        public int TagID { get; set; }

        // Navigation property
        public Novel Novel { get; set; } = null;
        public Tag Tag { get; set; } = null;
    }

}
