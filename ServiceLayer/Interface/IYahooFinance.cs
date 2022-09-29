using DTO.ReqDTO;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IYahooFinance
    {
        public Task<CommonResponse> GetAllStockData(StockDataReqDTO stockDataReqDTO);

        public Task<CommonResponse> GetYahooFinanceData(StockDataReqDTO stockDataReqDTO);

        public CommonResponse GetHistoricalData();
    }
}
