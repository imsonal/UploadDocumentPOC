using Helper.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interface;
using TradingViewUdfProvider.Models;

namespace UploadDocumentPOCWebAPI.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class TradingViewController : ControllerBase
    {
        private readonly ITradingView _iTradingViewProvider;
        public TradingViewController(ITradingView iTradingViewProvider)
        {
            iTradingViewProvider = _iTradingViewProvider;
        }
        /// Get initial configuration
        //[HttpGet("Confiuration-1")]
        //public async Task<CommonResponse> GetConfiguration()
        //{
        //    TvConfiguration tvConfiguration = new TvConfiguration();
        //    CommonResponse response = new CommonResponse();
        //    try
        //    {
        //        response = await _iTradingViewProvider.GetConfiguration();
        //     }
        //    catch (Exception ex)
        //    {
        //        response.Data = ex.ToString();
        //        response.Message = ex.Message;
        //    }
        //    return response;
        //}
      //  [Microsoft.AspNetCore.Mvc.Route("config-1")]
        [HttpGet("config-4")]
        public async Task<CommonResponse> GetConfig()
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = await _iTradingViewProvider.GetConfiguration();
            return commonResponse;
        }

    }
}
