using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRepoCodeFirst.Entities
{
    public class Course
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string CourseName { get; set; }

        public User User { get; set; }
    }
}
