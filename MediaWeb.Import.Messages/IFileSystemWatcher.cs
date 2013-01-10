using System.IO;

namespace MediaWeb.Import.Messages
{
    public interface IFileSystemWatcher
    {
        /// <devdoc> 
        ///    <para>
        ///       Gets or sets the type of changes to watch for. 
        ///    </para> 
        /// </devdoc>
        NotifyFilters NotifyFilter { get; set; }

        /// <devdoc>
        ///    <para>Gets or sets a value indicating whether the component is enabled.</para>
        /// </devdoc> 
        bool EnableRaisingEvents { get; set; }

        /// <devdoc> 
        ///    <para>Gets or sets the filter string, used to determine what files are monitored in a directory.</para>
        /// </devdoc> 
        string Filter { get; set; }

        /// <devdoc> 
        ///    <para>
        ///       Gets or sets a
        ///       value indicating whether subdirectories within the specified path should be monitored.
        ///    </para> 
        /// </devdoc>
        bool IncludeSubdirectories { get; set; }

        /// <devdoc>
        ///    <para>Gets or 
        ///       sets the size of the internal buffer.</para> 
        /// </devdoc>
        int InternalBufferSize { get; set; }

        /// <devdoc> 
        ///    <para>Gets or sets the path of the directory to watch.</para>
        /// </devdoc>
        string Path { get; set; }

        /// <devdoc>
        ///    <para>Notifies the object that initialization is beginning and tells it to standby.</para> 
        /// </devdoc> 
        void BeginInit();

        /// <devdoc> 
        ///    <para>
        ///       Notifies the object that initialization is complete.
        ///    </para>
        /// </devdoc> 
        void EndInit();

        /// <devdoc> 
        ///    <para>
        ///       Occurs when a file or directory in the specified <see cref='System.IO.FileSystemWatcher.Path'/> 
        ///       is changed.
        ///    </para>
        /// </devdoc>
        event FileSystemEventHandler Changed;

        /// <devdoc>
        ///    <para> 
        ///       Occurs when a file or directory in the specified <see cref='System.IO.FileSystemWatcher.Path'/> 
        ///       is created.
        ///    </para> 
        /// </devdoc>
        event FileSystemEventHandler Created;

        /// <devdoc>
        ///    <para> 
        ///       Occurs when a file or directory in the specified <see cref='System.IO.FileSystemWatcher.Path'/>
        ///       is deleted. 
        ///    </para> 
        /// </devdoc>
        event FileSystemEventHandler Deleted;

        /// <devdoc>
        ///    <para>
        ///       Occurs when the internal buffer overflows.
        ///    </para> 
        /// </devdoc>
        event ErrorEventHandler Error;

        /// <devdoc> 
        ///    <para>
        ///       Occurs when a file or directory in the specified <see cref='System.IO.FileSystemWatcher.Path'/> 
        ///       is renamed.
        ///    </para>
        /// </devdoc>
        event RenamedEventHandler Renamed;

        /// <devdoc> 
        ///    <para>
        ///       A synchronous method that returns a structure that
        ///       contains specific information on the change that occurred, given the type
        ///       of change that you wish to monitor. 
        ///    </para>
        /// </devdoc> 
        WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType);

        /// <devdoc>
        ///    <para>
        ///       A synchronous 
        ///       method that returns a structure that contains specific information on the change that occurred, given the
        ///       type of change that you wish to monitor and the time (in milliseconds) to wait before timing out. 
        ///    </para> 
        /// </devdoc>
        WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout);

        string ToString();
    }
}