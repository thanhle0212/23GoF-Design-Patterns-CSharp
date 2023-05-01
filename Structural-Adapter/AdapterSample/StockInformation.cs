using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterSample
{
    public class StockInformation
    {
        public string StockKey { get; set; }
        public string StockName { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
    }
}