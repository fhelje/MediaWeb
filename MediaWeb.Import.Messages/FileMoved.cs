using System;

namespace MediaWeb.Import.Messages
{
    public class FileMoved
    {
        public Guid FileId { get; set; }
        public string SeriesName { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string Hash { get; set; }
    }
}