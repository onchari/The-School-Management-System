using System.Collections.Generic;

namespace TheSma.WebApi.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Stream> Streams { get; set; }
    }
}
