using System;

namespace MediaWeb.Import.Messages
{
    public class MediaHashCalculated
    {
        public Guid FileId { get; set; }
        public string Hash { get; set; }
    }
}