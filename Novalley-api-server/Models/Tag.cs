using System.ComponentModel.DataAnnotations;

namespace Novalley_api_server.Models
{
    public class Tag
    {
        [Key]
        public int TagID { get; set; }
        public string TagName { get; set; } = string.Empty;
    }
}
