using DTO.ResDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Helper
{
    public class YahooFinance
    {
        private readonly WebClient webClient;

       // private readonly ICsvParser csvParser;
        public StockDataResDTO RetrieveStock(string ticker)
        {
            // return csvParser.RetrieveStock(ticker);
            return null;
            
        }
    }
}
