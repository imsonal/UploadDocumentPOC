using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class StockHistoryMst
    {
        public int Id { get; set; }
        public string? Currency { get; set; }
        public string? Symbol { get; set; }
        public string? ExchangeName { get; set; }
        public string? InstrumentType { get; set; }
        public string? TimeStamp { get; set; }
        public string? Openvalue { get; set; }
        public string? High { get; set; }
        public string? Low { get; set; }
        public string? Closevalue { get; set; }
        public string? Volume { get; set; }
        public string? Error { get; set; }
    }
}
