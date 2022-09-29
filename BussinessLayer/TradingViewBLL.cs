using Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Skender.Stock.Indicators;
using TradingViewUdfProvider.Models;
using DTO.ReqDTO;

namespace BussinessLayer
{
    public class TradingViewBLL
    {
        public async Task<CommonResponse> GetConfiguration()
        {
            CommonResponse commonResponse = new CommonResponse();
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    //RequestUri = new Uri("https://trading-view.p.rapidapi.com/exchanges/list"),
                    RequestUri = new Uri("https://yh-finance.p.rapidapi.com/market/v2/get-quotes?region=US&symbols=AMD%2CIBM%2CAAPL"),
                    Headers =
                 {
                   { "X-RapidAPI-Key", "e12a22699bmsh33881028c6f741cp1b3bb1jsn518e7f498d1b" },
                   { "X-RapidAPI-Host", "yh-finance.p.rapidapi.com" },
                 },
                };

                using (var response = await client.SendAsync(request))
                {
                    // response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    //  Console.WriteLine(body);
                    commonResponse.Message = "Success...!!!!";
                    commonResponse.Data = body;
                    commonResponse.Status = true;
                    commonResponse.StatusCode = HttpStatusCode.OK;

                }



                // string csvData;
                // string symbols = "GOOG, IBM, FB";
                //// Parse YahooFinance = new Parse();

                // using (WebClient web = new WebClient())
                // {
                //     csvData = web.DownloadString("http://finance.yahoo.com/d/quotes/csv?s=" + symbols + "&f=sa2l1");
                //     List<StockInfoReqDTO> stocks = Parse(csvData);

                //     commonResponse.Data = stocks;
                // }
            }

            catch
            {
                commonResponse.Message = "Fail...!!!!";
                commonResponse.Status = false;
                commonResponse.StatusCode = HttpStatusCode.BadRequest;
            }
            return commonResponse;
        }

        //public async Task<CommonResponse> GetConfiguration()
        //{
        //    CommonResponse commonResponse = new CommonResponse();
        //    try
        //    {
        //        string csvData;
        //        List<StockInfoReqDTO> stocks = new List<StockInfoReqDTO>();
        //        string[] rows = csvData.Replace("r", "").Replace("\"", "").Split('\n');
        //        foreach (string row in rows)
        //        {
        //            if (string.IsNullOrEmpty(row)) continue;
        //            string[] cols = row.Split(',');
        //            StockInfoReqDTO s = new StockInfoReqDTO();
        //            s.Symbol = cols[0].Trim();
        //            s.AverageVolume = Convert.ToDecimal((cols[1] == "N/A") ? "0" : cols[1]);
        //            s.LastTradePrice = Convert.ToDecimal((cols[2] == "N/A") ? "0" : cols[2]);
        //            stocks.Add(s);
        //        }
        //        commonResponse.Data = stocks;
        //        commonResponse.StatusCode = HttpStatusCode.OK;
        //        commonResponse.Status = true;
        //       // return commonResponse;
        //    }
        //    catch (Exception ex)
        //    {
        //        //handle error
        //        string error = ex.Message.ToString();
        //    }
        //    return commonResponse;
        //}



    }
}
