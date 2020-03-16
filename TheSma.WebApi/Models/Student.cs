using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSma.WebApi.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public DateTime dateTime { get; set; }
        public char Gender { get; set; }

        public virtual ICollection<StudentParent> StudentParents { get; set; }
    }
}
