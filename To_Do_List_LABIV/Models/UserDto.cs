using System.ComponentModel.DataAnnotations;

namespace To_Do_List_LABIV.Models
{
    public class UserDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
