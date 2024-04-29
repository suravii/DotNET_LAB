using System.ComponentModel.DataAnnotations;

namespace AdoCrud.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(60, MinimumLength =2, ErrorMessage ="Name must be 2 to 60 character long.")]
        public string Name { get; set; }

        public string Stream { get; set; }
    }
}
