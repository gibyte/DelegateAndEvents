using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class FileExplorer
    {
        public event EventHandler<FileArgs>? FileFound;
        private bool shouldContinueExploring = true;
        private CancellationTokenSource? cancellationTokenSource;

        public void ExploreDirectory(string path)
        {
            shouldContinueExploring = true;
            foreach (var file in Directory.GetFiles(path))
            {
                if (!shouldContinueExploring)
                    break;
                OnFileFound(new FileArgs(file));
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }

        public void CancelExploration()
        {
            shouldContinueExploring = false;
        }

        internal void CancelSearch()
        {
            cancellationTokenSource?.Cancel();
        }
    }
}
