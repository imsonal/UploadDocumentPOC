using Helper.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interface;

namespace UploadDocumentPOCWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FTPFileController : ControllerBase
    {
        private readonly IFTPFile _iFTPFile;

        public FTPFileController(IFTPFile iFTPFile)
        {
            _iFTPFile = iFTPFile;
        }
        [HttpGet("DownloadFTPFile")]
        public CommonResponse DownloadFTPFile()
        { 
            CommonResponse commonResponse = new CommonResponse();
            try
            {
                commonResponse = _iFTPFile.DownloadFTPFile();
            }
            catch(Exception ex)
            {
                commonResponse.Data = ex.ToString();
                commonResponse.Message = ex.Message;
            }
            return commonResponse;
        }

    }
}
