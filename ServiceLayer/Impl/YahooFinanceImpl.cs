using BussinessLayer;
using DTO.ReqDTO;
using Helper.Models;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Impl
{
    public class YahooFinanceImpl : IYahooFinance
    {
        private readonly YahooFinanceBLL _yahooFIinanceBLL;
        public YahooFinanceImpl(YahooFinanceBLL yahooFinanceBLL)
        { 
            _yahooFIinanceBLL = yahooFinanceBLL;
        }

        public async Task<CommonResponse> GetAllStockData(StockDataReqDTO stockDataReqDTO)
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = await _yahooFIinanceBLL.GetAllStockData(stockDataReqDTO);
            return commonResponse;
        }

        public async Task<CommonResponse> GetYahooFinanceData(StockDataReqDTO stockDataReqDTO)
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = await _yahooFIinanceBLL.GetYahooFinanceData(stockDataReqDTO);
            return commonResponse;
        }

        public CommonResponse GetHistoricalData()
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = _yahooFIinanceBLL.GetHistoricalData();
            return commonResponse;
        }
    }
}
