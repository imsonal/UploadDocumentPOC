using BussinessLayer;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Impl
{
    public class FTPFileImpl
    {
        private readonly FTPFileBLL _fTPFileBLL;

        public FTPFileImpl(FTPFileBLL fTPFileBLL)
        {
            _fTPFileBLL = fTPFileBLL;
        }

        public CommonResponse DownloadFTPFile()
        {
            return _fTPFileBLL.DownloadFTPFile();
        }
    }
}
