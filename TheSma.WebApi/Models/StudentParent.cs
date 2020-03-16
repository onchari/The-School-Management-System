using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSma.WebApi.Models
{
    public class StudentParent
    {
        public int StudentId { get; set; }
        public int ParentId { get; set; }

        public Student Student { get; set; }
        public Parent Parent { get; set; }
    }
}
