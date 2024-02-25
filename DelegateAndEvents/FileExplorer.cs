using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class FileExplorer
    {
        public event EventHandler<FileArgs> FileFound;

        public void ExploreDirectory(string path)
        {
            foreach (var file in Directory.GetFiles(path))
            {
                OnFileFound(new FileArgs(file));
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }
    }
}
