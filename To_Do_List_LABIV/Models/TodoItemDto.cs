using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace To_Do_List_LABIV.Models
{
    public class TodoItemDto
    {
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
