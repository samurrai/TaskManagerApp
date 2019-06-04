using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Services
{
    public class FileDownloader
    {
        public void DownloadFile(string filePath, string fileName)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(filePath, fileName);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
