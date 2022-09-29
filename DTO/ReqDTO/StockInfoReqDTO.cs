using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ReqDTO
{
    public class StockInfoReqDTO
    {
        public string Symbol { get; set; }
        public decimal AverageVolume { get; set; }
        public decimal LastTradePrice { get; set; }
    }
}
