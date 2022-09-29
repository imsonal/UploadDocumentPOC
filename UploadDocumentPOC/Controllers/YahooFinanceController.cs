using DTO.ReqDTO;
using Mapster;
using Helper.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interface;
using UploadDocumentPOCWebAPI.ViewModel.ReqViewModel;
using DTO.ResDTO;
using UploadDocumentPOCWebAPI.ViewModel.ResViewModel;

namespace UploadDocumentPOCWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YahooFinanceController : ControllerBase
    {
        private readonly IYahooFinance _iYahooFinance;
        private readonly ITradingView _iTradingView;

        public YahooFinanceController(IYahooFinance iYahooFinance, ITradingView iTradingView)
        {
            _iYahooFinance = iYahooFinance;
            _iTradingView = iTradingView;
        }

        [HttpPost("GetStockData")]
        public async Task<CommonResponse> GetStockData(StockDataReqViewModel stockDataReqViewModel)
        {
            CommonResponse commonResponse = new CommonResponse();
            try
            {
                commonResponse = await _iYahooFinance.GetAllStockData(stockDataReqViewModel.Adapt<StockDataReqDTO>());
                //List<StockDataResDTO> stockDataResDTO = commonResponse.Data ?? new List<StockDataResDTO>();
                //commonResponse.Data = stockDataResDTO.Adapt<StockDataResViewModel>();

            }
            catch (Exception ex)
            {
                commonResponse.Data = ex.ToString();
                commonResponse.Message = ex.Message;
            }
            return commonResponse;
        }

        [HttpPost("GetYahooFinanceData")]
        public async Task<CommonResponse> GetYahooFinanceData(StockDataReqViewModel stockDataReqViewModel)
        {
            CommonResponse commonResponse = new CommonResponse();
            try
            {
                commonResponse = await _iYahooFinance.GetYahooFinanceData(stockDataReqViewModel.Adapt<StockDataReqDTO>());
                // List<DataResDTO> dataResDTO = commonResponse.Data ?? new List<DataResDTO>();
                // commonResponse.Data = stockDataResDTO.Adapt<StockDataResViewModel>();
                //  commonResponse.Data = commonResponse;

            }
            catch (Exception ex)
            {
                commonResponse.Data = ex.ToString();
                commonResponse.Message = ex.Message;
            }
            return commonResponse;
        }
        [HttpGet("config-1")]
        public async Task<CommonResponse> GetConfig()
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = await _iTradingView.GetConfiguration();
            return commonResponse;
        }

        [HttpGet("GetHistoricalData")]
        public CommonResponse GetHistoricalData()
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse =  _iYahooFinance.GetHistoricalData();
            return commonResponse;
        }

    } 
}
