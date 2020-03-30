namespace TheSma.WebApi.Models
{
    public class Stream
    {
        public int StreamId { get; set; }
        public string StreamName { get; set; }

        public Class Class { get; set; }
        public int ClassId { get; set; }
    }
}
