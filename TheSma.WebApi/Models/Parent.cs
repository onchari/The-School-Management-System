using System.Collections.Generic;

namespace TheSma.WebApi.Models
{
    public class Parent
    {
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public char Gender { get; set; }

        public   virtual ICollection<StudentParent> StudentParents { get; set; }
    }
}
