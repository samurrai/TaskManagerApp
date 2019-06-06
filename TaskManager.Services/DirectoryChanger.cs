using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Services
{
    public class DirectoryChanger
    {
        public void ChangeDirectory(string from, string to)
        {
            DirectoryInfo destDir = new DirectoryInfo(to);
            if (destDir.Exists)
                destDir.Delete(true);
            new DirectoryInfo(from).MoveTo(to);
        }
    }
}
