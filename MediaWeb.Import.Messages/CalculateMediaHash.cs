using System;

namespace MediaWeb.Import.Messages
{
    public class CalculateMediaHash
    {
        public Guid FileId { get; set; }
        public string Path { get; set; }        
    }
}