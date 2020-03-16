using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSma.WebApi.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int    StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName  { get; set; }

        public string OtherName { get; set; }
        public DateTime DateTime{ get; set; }

        [Required]
        public char Gender { get; set; }

        public virtual ICollection<StudentParent> StudentParents { get; set; }
    }
}
