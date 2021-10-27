using System.ComponentModel.DataAnnotations;

namespace Rest_Example.Model
{
    public class Task
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Notes { get; set; }
        [Required]
        public string TimeAllocated { get; set; }

    }
}