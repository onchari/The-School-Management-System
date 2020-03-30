using System.Collections.Generic;
using TheSma.WebApi.Models;

namespace TheSma.WebApi.ViewModels
{
    public class ClassViewModel
    {
        public int VmId { get; set; }
        public string VmName { get; set; }
        public virtual ICollection<Student> VmStudents { get; set; }
        public virtual ICollection<Stream> VmStreams { get; set; }
    }
}
