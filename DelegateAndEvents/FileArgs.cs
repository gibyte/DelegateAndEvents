namespace DelegateAndEvents
{
    public class FileArgs : EventArgs
    {
        public string FileName { get; }
        public bool StopSearch { get; set; }

        public FileArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}