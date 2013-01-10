using System;

namespace MediaWeb.Import.Messages
{
    public class FileRecieved
    {
        public Guid FileId { get; set; }
        public DateTime Added { get; set; }
        public string Path { get; set; }
    }
}
