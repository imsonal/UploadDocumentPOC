using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ResDTO
{
    public class PricingDataResDTO
    {
        public decimal? Ask { get; set; }

        public decimal? Bid { get; set; }

        public decimal? AskRealTime { get; set; }

        public decimal? BidRealTime { get; set; }

        public decimal? PreviousClose { get; set; }

        public decimal? Open { get; set; }

        public decimal? FiftyTwoWeekHigh { get; set; }

        public decimal? FiftyTwoWeekLow { get; set; }

        public decimal? FiftyTwoWeekLowChange { get; set; }

        public decimal? FiftyTwoWeekHighChange { get; set; }

        public decimal? FiftyTwoWeekLowChangePercent { get; set; }

        public decimal? FiftyTwoWeekHighChangePercent { get; set; }

        public string FiftyTwoWeekRange { get; set; }
    }
}
