using System;

namespace MediaWeb.Import.Messages
{
    public class ParseTvSeriesEpisodeNumbers : FileRecieved
    {
        public Guid FileId { get; set; }
        public string Path { get; set; }
    }
}