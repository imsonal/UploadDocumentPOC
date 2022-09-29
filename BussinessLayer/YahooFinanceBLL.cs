using CsvHelper;
using DataLayer.Entities;
using DTO.ReqDTO;
using DTO.ResDTO;
using ExcelDataReader;
using Helper;
using Helper.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Net;
using ExcelDataReader;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;
using YahooQuotesApi;

namespace BussinessLayer
{
    public class YahooFinanceBLL
    {
        //  private readonly YahooFinanceContext _yahooFinanceContext;
        private IHostingEnvironment _hostingEnvironment { get; }
        private readonly YahooFinanceContext _yahooFinanceContext;

        public YahooFinanceBLL(YahooFinanceContext yahooFinanceContext)
        {
            _yahooFinanceContext = yahooFinanceContext;
        }


        //GetAllHistoricalData
        public async Task<CommonResponse> GetAllStockData(StockDataReqDTO stockDataReqDTO)
        {
            CommonResponse commonResponse = new CommonResponse();
            string Symbol = stockDataReqDTO.Symbol;
            try
            {
                var quotes = new YahooQuotesBuilder()
                .WithHistoryStartDate(Instant.FromUtc(2020, 12, 1, 0, 0))
                .Build();

                var quotes1 = new YahooQuotesBuilder().ToResult();

                var item = await quotes.GetAsync("AAPL", HistoryFlags.PriceHistory);
                //for (int i = 0;i< item;i++)
                //{ 

                //    }

                // var result1 = Convert.ToDateTime(item.FirstTradeDate);
                var RegularMarketOpen = item.RegularMarketOpen;
                var RegularMarketDayHigh = item.RegularMarketDayHigh;
                var RegularMarketDayLow = item.RegularMarketDayLow;
                var ExchangeCloseTime = item.ExchangeCloseTime;
                var RegularMarketPreviousClose = item.RegularMarketPreviousClose;
                var RegularMarketVolume = item.RegularMarketVolume;
                var Ask = item.Ask;
                var AskSize = item.AskSize;
                var BidSize = item.AskSize;
                var result9 = item.Bid;
                var BookValue = item.BookValue;
                var Currency = item.Currency;
                var DisplayName = item.DisplayName;
                var DividendDate = item.DividendDate;
                var DividendDateSeconds = item.DividendDateSeconds;
                var DividendHistory = item.DividendHistory;
                var EarningsTime = item.EarningsTime;
                var EarningsTimeEnd = item.EarningsTimeEnd;
                var EarningsTimestamp = item.EarningsTimestamp;
                var EarningsTimestampEnd = item.EarningsTimestampEnd;
                var EarningsTimestampStart = item.EarningsTimestampStart;
                var EarningsTimeStart = item.EarningsTimeStart;
                var EpsCurrentYear = item.EpsCurrentYear;
                var lEpsForwardk = item.EpsForward;
                var EpsTrailingTwelveMonths = item.EpsTrailingTwelveMonths;
                var EsgPopulated = item.EsgPopulated;
                var Exchange = item.Exchange;
                var ShortName = item.ShortName;
                var AverageAnalystRating = item.AverageAnalystRating;
                var AverageDailyVolume10Day = item.AverageDailyVolume10Day;
                var AverageDailyVolume3Month = item.AverageDailyVolume3Month;
                var ExchangeTimeZoneName = item.ExchangeTimezoneName;
                var ExchangeTimezone = item.ExchangeTimezone;
                var EpsTraillingTwelveMonth = item.EpsTrailingTwelveMonths;
                var PriceHistory = item.PriceHistory.Value;

                //LocalDateTime EarningsTimeEndDateTime = LocalDateTime.FromDateTime(EarningsTimeEnd);
                //LocalDateTime EarningsTimeStartDateTime = LocalDateTime.FromDateTime(Convert.ToDateTime(EarningsTimeStart));
                //LocalDateTime ExchangeDateTime = LocalDateTime.FromDateTime(Convert.ToDateTime(ExchangeCloseTime));
                //LocalDateTime EarningsTimeDateTime = LocalDateTime.FromDateTime(Convert.ToDateTime(EarningsTime));

                SymbolDataMst symbol = new SymbolDataMst();
                symbol.Date = DateTime.Now;
                symbol.Openvalue = Convert.ToString(RegularMarketOpen);
                symbol.High = Convert.ToString((double)RegularMarketDayHigh);
                symbol.Low = Convert.ToString(RegularMarketDayLow);
                symbol.Closevalue = Convert.ToString(ExchangeCloseTime); //Convert.ToString(ExchangeDateTime);
                symbol.AdjClose = Convert.ToString(ExchangeCloseTime);
                symbol.Volume = Convert.ToString(RegularMarketVolume);
                symbol.Currency = Currency;
                symbol.EpsCurrentYear = Convert.ToString(EpsCurrentYear);
                symbol.EarningTimeStart = DateTime.Now;//Convert.ToDateTime(EarningsTimeStartDateTime);
                symbol.EarningTimeStampStart = Convert.ToString(EarningsTimestampStart);
                symbol.EarningTimeStampEnd = Convert.ToString(EarningsTimestampEnd);
                symbol.BookValue = Convert.ToString(BookValue);
                symbol.DividendHistory = Convert.ToString(DividendHistory);
                symbol.EarningTime = DateTime.Now;//Convert.ToDateTime(EarningsTimeDateTime);
                symbol.AverageAnalystRating = AverageAnalystRating;
                symbol.AverageDailyVolume10Day = Convert.ToString(AverageDailyVolume10Day);
                symbol.AverageDailyVolume3Month = Convert.ToString(AverageDailyVolume3Month);
                symbol.DisplayName = DisplayName;
                symbol.DividendDate = Convert.ToString(DividendDate);
                symbol.DividendDateSeconds = Convert.ToString(DividendDateSeconds);
                symbol.DividendHistory  =Convert.ToString(DividendHistory);
                symbol.EarningTimeEnd = DateTime.Now;//Convert.ToDateTime(EarningsTimeEndDateTime);
                symbol.EarningTimeStamp = Convert.ToString(EarningsTimestamp);
                symbol.ExchangeTimeZoneName = Convert.ToString(ExchangeTimeZoneName);
                symbol.ExchangeTimeZone = Convert.ToString(ExchangeTimezone);
                symbol.EpsTraillingTwelveMonth = Convert.ToString(EpsTraillingTwelveMonth);
                

               _yahooFinanceContext.SymbolDataMsts.Add(symbol);
                _yahooFinanceContext.SaveChanges();
                commonResponse.Message = "Success....!!!";
                commonResponse.Status = true;
                commonResponse.StatusCode = HttpStatusCode.OK;


               // StockDataLogMst stockDataLogMst = new StockDataLogMst();


                //using (var writer = new StreamWriter(@"Yahoo-api-out-item.csv"))
                //using (var csv = new CsvWriter(writer))
                //{
                //    //csv.WriteRecords(quotes1.Value.WithHistoryStartDate(Instant.FromUtc(2020, 12, 1, 0, 0)).Build());
                //    //var result = item1.Properties;
                //    csv.WriteRecords(item.PriceHistory.Value);
                //    var result = item.Properties.Values;

                //    commonResponse.Message = "Success....!!!";
                //    commonResponse.Status = true;
                //    commonResponse.StatusCode = HttpStatusCode.OK;
                //}

                using (var writer = new StreamWriter(@"yahoo-api-out-12.csv"))
                using (var csv = new CsvWriter(writer))
                {
                    //csv.WriteRecords(item.RegularMarketChangePercent.value);
                    csv.WriteRecords(item.PriceHistory.Value);
                    var result = item.PriceHistory.Value;

                    StockDataLogMst data = new StockDataLogMst();
                    DataSet dsExcelRecords = new DataSet();
                    IExcelDataReader reader = null;
                    var stream = System.IO.File.Open(@"yahoo-api-out-11.csv", FileMode.Open, FileAccess.Read);
                    reader = ExcelReaderFactory.CreateCsvReader(stream);
                    dsExcelRecords = reader.AsDataSet();
                    reader.Close();


                    if ((dsExcelRecords != null))
                    {
                        DataTable dtUserRecords = dsExcelRecords.Tables[0];
                        for (int i = 1; i < dtUserRecords.Rows.Count; i++)
                        {
                            // csvDataMst.Surname = dtUserRecords.Rows[i][1].ToString() != " " ? Convert.ToString(dtUserRecords.Rows[i][1]) : " ";
                            data.Year = dtUserRecords.Rows[i][0].ToString() != "" ? Convert.ToInt32(dtUserRecords.Rows[i][0]) : 0;
                            data.Month = dtUserRecords.Rows[i][1].ToString() != "" ? Convert.ToInt32(dtUserRecords.Rows[i][1]) : 0;
                            data.Day = dtUserRecords.Rows[i][2].ToString() != "" ? Convert.ToInt32(dtUserRecords.Rows[i][2]) : 0;
                            data.DayOfWeek = dtUserRecords.Rows[i][3].ToString() != "" ? Convert.ToString(dtUserRecords.Rows[i][3]) : "";
                            data.YearOfEra = dtUserRecords.Rows[i][4].ToString() != "" ? Convert.ToInt32(dtUserRecords.Rows[i][4]) : 0;
                            data.Open = dtUserRecords.Rows[i][5].ToString() != "" ? Convert.ToDouble(dtUserRecords.Rows[i][5]) : 0;
                            data.High = dtUserRecords.Rows[i][6].ToString() != "" ? Convert.ToDouble(dtUserRecords.Rows[i][6]) : 0;
                            data.Low = dtUserRecords.Rows[i][7].ToString() != "" ? Convert.ToDouble(dtUserRecords.Rows[i][7]) : 0;
                            data.Close = dtUserRecords.Rows[i][8].ToString() != "" ? Convert.ToDouble(dtUserRecords.Rows[i][8]) : 0;
                            data.AdjustedClose = dtUserRecords.Rows[i][9].ToString() != "" ? Convert.ToDouble(dtUserRecords.Rows[i][9]) : 0;
                            data.Volume = dtUserRecords.Rows[i][10].ToString() != "" ? Convert.ToDouble(dtUserRecords.Rows[i][10]) : 0;
                            data.CreatedDate = DateTime.Now;


                        }

                        _yahooFinanceContext.StockDataLogMsts.AddRange(data);
                        _yahooFinanceContext.SaveChanges();
                        commonResponse.Message = "Success....!!!";
                        commonResponse.Status = true;
                        commonResponse.StatusCode = HttpStatusCode.OK;
                    }


                    }
                }
            catch (Exception ex)
            {
                commonResponse.Message = "Failed";
                commonResponse.Data = Symbol;
                commonResponse.Status = false;
                commonResponse.StatusCode = HttpStatusCode.BadRequest;
            }
            return commonResponse;
        }

        //GetAllHistoricalData //using API-Key
        public async Task<CommonResponse> GetYahooFinanceData(StockDataReqDTO stockDataReqDTO)
        {
            CommonResponse commonResponse = new CommonResponse();
            try
            {
                string baseurl = "http://agent.YahooFinance.com/new-api/";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseurl);
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Add("api-key", "https://query1.finance.yahoo.com/v7/finance/options/AAPL");

                    //client.DefaultRequestHeaders.Add("api-key", "https://query1.finance.yahoo.com/v7/finance/download/AAPL");
                    client.DefaultRequestHeaders.Add("accept", "application/json");

                    var response = await client.GetAsync("https://query1.finance.yahoo.com/v7/finance/options/AAPL");
                    // var response = await client.GetAsync("https://query1.finance.yahoo.com/v7/finance/download/AAPL");
                    var responsebody = response.Content.ReadAsStringAsync().Result;
                    DataResDTO apiresult = JsonConvert.DeserializeObject<DataResDTO>(responsebody);

                    using (var writer = new StreamWriter(@"yahoo-Finance-AllData.csv"))
                    using (var csv = new CsvWriter(writer))
                    {
                        csv.WriteRecord(apiresult);
                        var result = csv.ToString();
                        commonResponse.Data = responsebody;
                        commonResponse.StatusCode = HttpStatusCode.OK;
                        commonResponse.Status = true;
                        commonResponse.Message = "Success...!!!";
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

            return commonResponse;
        }

        public CommonResponse GetHistoricalData()
        {
            CommonResponse commonResponse = new CommonResponse();
            try
            {
                //var data = Yahoo.GetHistoricalAsync("IBM", new DateTime(2022, 9, 20), DateTime.Now).Result;
                // var data1 = YahooQuotesApi.Symbol.TryCreate("data",out Symbol IBM);
                // var data2 = Yahoo.Symbols;
                //var symbolResult = Yahoo.Symbols().ToResult();

                var wc = new WebClient();
                var str = wc.DownloadString("https://query1.finance.yahoo.com/v7/finance/chart/IBM?range=25y&interval=1d&indicators=quote&includeTimestamps=true&includePrePost=false&corsDomain=finance.yahoo.com");
                var data = JsonConvert.DeserializeObject<RootObject>(str);
                var result = new List<string>();
                var quotesInfo = data.chart.result.First();
                for (var i = 0; i < quotesInfo.timestamp.Count; i++)
                {
                    var quotesStr = new List<string>();
                    var quoteData = quotesInfo.indicators.quote.First();
                    quotesStr.Add(quotesInfo.timestamp[i].ToString(CultureInfo.InvariantCulture));
                    quotesStr.Add(quoteData.open[i].HasValue ? quoteData.open[i].ToString() : string.Empty);
                    quotesStr.Add(quoteData.high[i].HasValue ? quoteData.high[i].ToString() : string.Empty);
                    quotesStr.Add(quoteData.low[i].HasValue ? quoteData.low[i].ToString() : string.Empty);
                    quotesStr.Add(quoteData.close[i].HasValue ? quoteData.close[i].ToString() : string.Empty);
                    quotesStr.Add(quoteData.volume[i] != null ? quoteData.volume[i].ToString() : string.Empty);
                    result.Add(string.Join(",", quotesStr));
                }
                File.WriteAllLines("result.csv", result);


                commonResponse.Data = result;
                commonResponse.Message = "Success";
                commonResponse.Status = true;
                commonResponse.StatusCode = HttpStatusCode.OK;

            }
            catch (Exception ex)
            {
                commonResponse.Message = ex.Message;
                // commonResponse.Message = "Fail";
                commonResponse.Status = false;
                commonResponse.StatusCode = HttpStatusCode.BadRequest;
            }
            return commonResponse;
        }


    }
}
