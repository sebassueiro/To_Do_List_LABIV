using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace To_Do_List_LABIV.Models
{
    public class TodoItemGetDto
    {
        internal int id_todo_item;

        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
