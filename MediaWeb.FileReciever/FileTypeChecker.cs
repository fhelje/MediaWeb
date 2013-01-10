using System.IO;
using System.Text.RegularExpressions;

namespace MediaWeb.FileReciever
{
    public class FileTypeChecker
    {
        private const string regex = "S\\d{2}E\\d{2}";
        public bool IsTvSeries(string path)
        {
            var filename = Path.GetFileName(path);
            if (string.IsNullOrEmpty(filename))
            {
                return false;
            }
            var tvMatch = Regex.Match(filename.ToUpperInvariant(), regex);
            return tvMatch.Success;
        }
    }
}