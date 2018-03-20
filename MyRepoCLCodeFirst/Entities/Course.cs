using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyRepoCLCodeFirst.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int IdPerson { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        //[ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}
