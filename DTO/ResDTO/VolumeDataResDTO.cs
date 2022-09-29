using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ResDTO
{
    public class VolumeDataResDTO
    {
        public decimal? CurrentVolume { get; set; }

        public decimal? AskSize { get; set; }

        public decimal? BidSize { get; set; }

        public decimal? LastTradeSize { get; set; }

        public decimal? AverageDailyVolume { get; set; }
    }
}
