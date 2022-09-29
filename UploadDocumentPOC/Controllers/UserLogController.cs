using Helper.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interface;

namespace UploadDocumentPOCWebAPI.Controllers
{
    public class UserLogController : ControllerBase
    {
        private readonly IUserLog _iuserLog;

        public UserLogController(IUserLog iUserLog)
        { 
            _iuserLog = iUserLog;   
        }
        [HttpGet("GetAlluser")]
        public CommonResponse GetALLUser()
        { 
            CommonResponse commonResponse = new CommonResponse();
            try
            {
                //commonResponse = _iUploadDocument.GetAllCSVDocumentData(getAllCSVDataReqViewModel.Adapt<GetAllCSVDataReqDTO>());
                //List<GetAllCSVDocumnetResDTO> CSVDocumentResDTO = commonResponse.Data ?? new List<GetAllCSVDocumnetResDTO>();
                //commonResponse.Data = CSVDocumentResDTO.Adapt<List<GetAllCSVDocumnetResViewModel>>();
               // commonResponse = _iuserLog.GetAllProduct(getAllProductReqViewModel.Adapt<GetAllCSVDataReqDTO>());

            }
            catch (Exception ex)
            { 
                commonResponse.Message = ex.Message;
                commonResponse.StatusCode = System.Net.HttpStatusCode.NotFound;

            }
            return commonResponse;
        }
    }
}
