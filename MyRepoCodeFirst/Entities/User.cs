using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRepoCodeFirst.Entities
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Course> Courses { get; set; } 
    }
}
