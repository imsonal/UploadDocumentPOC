using BussinessLayer;
using Helper.Models;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingViewUdfProvider.Models;

namespace ServiceLayer.Impl
{
    public class TradingViewImpl : ITradingView
    {
        private readonly TradingViewBLL _tradingViewBLL;
        public TradingViewImpl(TradingViewBLL tradingViewBLL)
        { 
            _tradingViewBLL = tradingViewBLL;
        }

        public Task<TvSymbolSearch[]> FindSymbols(string query, string type, string exchange, int? limit)
        {
            throw new NotImplementedException();
        }

        public async Task<CommonResponse> GetConfiguration()
        {

            CommonResponse commonResponse = new CommonResponse();
            commonResponse = await _tradingViewBLL.GetConfiguration();
            return commonResponse;
        }

        public Task<TvBarResponse> GetHistory(DateTime from, DateTime to, string symbol, string resolution)
        {
            throw new NotImplementedException();
        }

        public Task<TvMark[]> GetMarks(DateTime from, DateTime to, string symbol, string resolution)
        {
            throw new NotImplementedException();
        }

        public Task<TvSymbolInfo> GetSymbol(string symbol)
        {
            throw new NotImplementedException();
        }

        //Task<TvConfiguration> ITradingView.GetConfiguration()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
