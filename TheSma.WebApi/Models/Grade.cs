using System.Collections.Generic;

namespace TheSma.WebApi.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
