using System;

namespace MediaWeb.Import.Messages
{
    public class TvSeriesEpisodeNumbersParsed : FileRecieved
    {
        public Guid FileId { get; set; }
        public string SeriesName { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
    }
}