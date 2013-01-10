using System.IO;

namespace MediaWeb.Import.Messages
{
    public class FileSystemWatcherWrapper : IFileSystemWatcher
    {
        private readonly FileSystemWatcher fileSystemWatcher;

        public FileSystemWatcherWrapper()
        {
            fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.Changed += FSWChanged;
            fileSystemWatcher.Created += FSWCreated;
            fileSystemWatcher.Deleted += FSWDeleted;
            fileSystemWatcher.Error += FSWError;
            fileSystemWatcher.Renamed += FSWRenamed;
        }

        #region IFileSystemWatcher Members

        public NotifyFilters NotifyFilter
        {
            get { return fileSystemWatcher.NotifyFilter; }
            set { fileSystemWatcher.NotifyFilter = value; }
        }

        public bool EnableRaisingEvents
        {
            get { return fileSystemWatcher.EnableRaisingEvents; }
            set { fileSystemWatcher.EnableRaisingEvents = value; }
        }

        public string Filter
        {
            get { return fileSystemWatcher.Filter; }
            set { fileSystemWatcher.Filter = value; }
        }

        public bool IncludeSubdirectories
        {
            get { return fileSystemWatcher.IncludeSubdirectories; }
            set { fileSystemWatcher.IncludeSubdirectories = value; }
        }

        public int InternalBufferSize
        {
            get { return fileSystemWatcher.InternalBufferSize; }
            set { fileSystemWatcher.InternalBufferSize = value; }
        }

        public string Path
        {
            get { return fileSystemWatcher.Path; }
            set { fileSystemWatcher.Path = value; }
        }

        public void BeginInit()
        {
            fileSystemWatcher.BeginInit();
        }

        public void EndInit()
        {
            fileSystemWatcher.EndInit();
        }

        public event FileSystemEventHandler Changed;
        public event FileSystemEventHandler Created;
        public event FileSystemEventHandler Deleted;
        public event ErrorEventHandler Error;
        public event RenamedEventHandler Renamed;

        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
        {
            return fileSystemWatcher.WaitForChanged(changeType);
        }

        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
        {
            return fileSystemWatcher.WaitForChanged(changeType, timeout);
        }

        #endregion

        private void FSWRenamed(object sender, RenamedEventArgs e)
        {
            InvokeRenamed(e);
        }

        private void FSWError(object sender, ErrorEventArgs e)
        {
            InvokeError(e);
        }

        private void FSWDeleted(object sender, FileSystemEventArgs e)
        {
            InvokeDeleted(e);
        }

        private void FSWCreated(object sender, FileSystemEventArgs e)
        {
            InvokeCreated(e);
        }

        private void FSWChanged(object sender, FileSystemEventArgs e)
        {
            InvokeChanged(e);
        }

        private void InvokeChanged(FileSystemEventArgs e)
        {
            var handler = Changed;
            if (handler != null) handler(this, e);
        }

        private void InvokeCreated(FileSystemEventArgs e)
        {
            var handler = Created;
            if (handler != null) handler(this, e);
        }

        private void InvokeDeleted(FileSystemEventArgs e)
        {
            var handler = Deleted;
            if (handler != null) handler(this, e);
        }

        private void InvokeError(ErrorEventArgs e)
        {
            var handler = Error;
            if (handler != null) handler(this, e);
        }

        private void InvokeRenamed(RenamedEventArgs e)
        {
            var handler = Renamed;
            if (handler != null) handler(this, e);
        }
    }
}