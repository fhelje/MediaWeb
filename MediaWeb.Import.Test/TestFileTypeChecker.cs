using FluentAssertions;
using MediaWeb.FileReciever;
using NUnit.Framework;

namespace MediaWeb.Import.Test
{
    [TestFixture]
    public class TestFileTypeChecker
    {
        [TestCase(@"D:\Torrents\New\Lie.To.Me.S03E10.720p.HDTV.X264-DIMENSION.mkv",      true)]
        [TestCase(@"D:\Torrents\New\Greys.Anatomy.S07E12.720p.HDTV.X264-DIMENSION.mkv",  true)]
        [TestCase(@"D:\Torrents\New\Lie.To.Me.S03E09.720p.HDTV.X264-DIMENSION.mkv",      true)]
        [TestCase(@"D:\Torrents\New\boardwalk.empire.s01e10.720p.hdtv.x264-immerse.mkv", true)]
        [TestCase(@"D:\Torrents\New\Boardwalk.Empire.S01E12.720p.HDTV.x264-CTU.mkv",     true)]
        [TestCase(@"D:\Torrents\New\Bones.S06E10.720p.HDTV.X264-DIMENSION.mkv",          true)]
        [TestCase(@"D:\Torrents\New\californication.s04e01.720p.hdtv.x264-immerse.mkv",  true)]
        [TestCase(@"D:\Torrents\New\Caprica S01E15 - The Dirteaters-x264-720p-HD.mkv",   true)]
        [TestCase(@"D:\Torrents\New\Castle.2009.S03E09.720p.HDTV.X264-DIMENSION.mkv",    true)]
        [TestCase(@"D:\Torrents\New\sanctuary.us.s03e01.720p.hdtv.x264-immerse.mkv",     true)]
        [TestCase(@"D:\Torrents\New\A.file.720p.HDTV.X264-DIMENSION.mkv",                false)]
        [TestCase(@"D:\Torrents\New\",                                                   false)]
        public void CheckForTvSerie(string path, bool tvSeries)
        {
            var sut = new FileTypeChecker();
            sut.IsTvSeries(path).Should().Be(tvSeries);
        }
    }
}