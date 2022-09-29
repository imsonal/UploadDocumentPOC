using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class StockDataLogMst
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public string? DayOfWeek { get; set; }
        public int? YearOfEra { get; set; }
        public double? Open { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Close { get; set; }
        public double? AdjustedClose { get; set; }
        public double? Volume { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
