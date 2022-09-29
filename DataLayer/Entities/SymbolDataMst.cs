using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class SymbolDataMst
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Openvalue { get; set; }
        public string? High { get; set; }
        public string? Low { get; set; }
        public string? Closevalue { get; set; }
        public string? AdjClose { get; set; }
        public string? Volume { get; set; }
        public string? Ask { get; set; }
        public string? AskSize { get; set; }
        public string? AverageAnalystRating { get; set; }
        public string? AverageDailyVolume10Day { get; set; }
        public string? AverageDailyVolume3Month { get; set; }
        public string? Bid { get; set; }
        public string? BidSize { get; set; }
        public string? BookValue { get; set; }
        public string? Currency { get; set; }
        public string? DisplayName { get; set; }
        public string? DividendDate { get; set; }
        public string? DividendDateSeconds { get; set; }
        public string? DividendHistory { get; set; }
        public DateTime? EarningTime { get; set; }
        public DateTime? EarningTimeEnd { get; set; }
        public DateTime? EarningTimeStart { get; set; }
        public string? EarningTimeStamp { get; set; }
        public string? EarningTimeStampEnd { get; set; }
        public string? EarningTimeStampStart { get; set; }
        public string? EpsCurrentYear { get; set; }
        public string? EpsForward { get; set; }
        public string? EpsTraillingTwelveMonth { get; set; }
        public string? EsgPopulated { get; set; }
        public string? Exchnage { get; set; }
        public DateTime? ExchangeCloseTime { get; set; }
        public string? ExchangeDataDelayedBy { get; set; }
        public string? ExchangeTimeZone { get; set; }
        public string? ExchangeTimeZoneName { get; set; }
    }
}
