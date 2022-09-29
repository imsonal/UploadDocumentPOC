using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ResDTO
{
    public class DataResDTO
    {


      

        //       "Date": "2022-01-03",
        //"Open": "144.475494",
        //"High": "145.550003",
        //"Low": "143.502502",
        //"Close": "145.074493",
        //"Adj Close": "145.074493",
        //"Volume": "25214000"

        //public DateTime? Date { get; set; }
        //public int? Open { get; set; }
        //public int? High { get; set; }
        //public int? Low { get; set; }
        //public int? Close { get; set; }
        //public int? AdjClose { get; set; }
        //public int Volume { get; set; }

        //"quote":{
        //       "language":"en-US",
        public string language { get; set; }
        public string region { get; set; }
        public string quoteType { get; set; }
        public string typeDisp { get; set; }
        public string quoteSourceName { get; set; }
        public bool triggerable { get; set; }
        public string customPriceAlertConfidence { get; set; }

        public string postMarketChangePercent { get; set; }
        public string postMarketTime { get; set; }
        public string postMarketPrice { get; set; }
        public string postMarketChange { get; set; }
        public string regularMarketChange { get; set; }
        public string regularMarketChangePercent { get; set; }
        public string regularMarketTime { get; set; }
        public string regularMarketPrice { get; set; }
        public string regularMarketDayHigh { get; set; }
        public string regularMarketDayRange { get; set; }
        public string regularMarketDayLow { get; set; }
        public string regularMarketVolume { get; set; }
        public string bid { get; set; }
        public string ask { get; set; }
        public string bidSize { get; set; }
        public int askSize { get; set; }
        public string fullExchangeName { get; set; }
        public string financialCurrency { get; set; }
        public string regularMarketOpen { get; set; }
        public string averageDailyVolume3Month { get; set; }

        public string fiftyTwoWeekLowChange { get; set; }
        public string currency { get; set; }
        public string gmtOffSetMilliseconds { get; set; }
        public string market { get; set; }
        public string esgPopulated { get; set; }
        public string exchange { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string messageBoardId { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public string firstTradeDateMilliseconds { get; set; }
        public string priceHint { get; set; }
        public string fiftyTwoWeekLowChangePercent { get; set; }
        public string fiftyTwoWeekRange { get; set; }
        public string fiftyTwoWeekHighChange { get; set; }
        public string fiftyTwoWeekHighChangePercent { get; set; }
        public string fiftyTwoWeekLow { get; set; }
        public string fiftyTwoWeekHigh { get; set; }
        public string dividendDate { get; set; }
        public string earningsTimestamp { get; set; }
        public string earningsTimestampStart { get; set; }
        public string earningsTimestampEnd { get; set; }
        public string trailingAnnualDividendRate { get; set; }
        public string trailingPE { get; set; }
        public string trailingAnnualDividendYield { get; set; }
        public string epsTrailingTwelveMonths { get; set; }
        public string epsForward { get; set; }
        public string epsCurrentYear { get; set; }
        public string priceEpsCurrentYear { get; set; }
        public string sharesOutstanding { get; set; }
        public string bookValue { get; set; }
        public string fiftyDayAverage { get; set; }
        public string fiftyDayAverageChange { get; set; }
        public string fiftyDayAverageChangePercent { get; set; }
        public string twoHundredDayAverage { get; set; }
        public string twoHundredDayAverageChange { get; set; }
        public string twoHundredDayAverageChangePercent { get; set; }
        public string marketCap { get; set; }
        public string forwardPE { get; set; }
        public string priceToBook { get; set; }
        public string sourceInterval { get; set; }
        public string exchangeDataDelayedBy { get; set; }
        public string pageViewGrowthWeekly { get; set; }
        public string averageAnalystRating { get; set; }
        public string tradeable { get; set; }
        public string marketState { get; set; }
        public string displayName { get; set; }
        public string symbol { get; set; }

        public string? contractSymbol { get; set; }
        public string? strike { get; set; }
       // public string? currency { get; set; }
        public string? lastPrice { get; set; }
        public string? change { get; set; }
        public string? percentChange { get; set; }
        public string? volume { get; set; }
        public string? openInterest { get; set; }
     //   public string? bid { get; set; }
     //   public string? ask { get; set; }
        public string? contractSize { get; set; }
        public string? expiration { get; set; }
        public string? lastTradeDate { get; set; }
        public string? impliedVolatility { get; set; }
        public bool inTheMoney { get; set; }



    }


}
