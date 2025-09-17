using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        [StringLength(100)]
        public string Course { get; set; }

        [Range(0, 100)]
        public decimal? Marks { get; set; }
    }
}
