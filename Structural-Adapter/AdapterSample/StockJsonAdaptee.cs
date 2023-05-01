using Newtonsoft.Json;

namespace AdapterSample
{
    //Defining the Adaptee to be accessed by the Client
    public class StockJsonAdaptee
    {
        private List<StockInformation> _listStocks;
        public StockJsonAdaptee()
        {
            _listStocks = new List<StockInformation>();
            _listStocks.Add(new StockInformation
            {
                StockKey = "TSLA",
                StockName = "Tesla, Inc.",
                Open = 160.9,
                High = 165,
                Low = 157.32
            });
            _listStocks.Add(new StockInformation
            {
                StockKey = "AMZN",
                StockName = "Amazon.com, Inc.",
                Open = 107.73,
                High = 109.48,
                Low = 104.33
            });
            _listStocks.Add(new StockInformation
            {
                StockKey = "AAPL",
                StockName = "Apple Inc.",
                Open = 168.49,
                High = 169.85,
                Low = 167.88
            });
            _listStocks.Add(new StockInformation
            {
                StockKey = "MSFT",
                StockName = "Microsoft Corporation",
                Open = 304.01,
                High = 308.93,
                Low = 303.31
            });

        }
        public string GetStockInformartion(string stockKey)
        {
            var result = _listStocks.FirstOrDefault(x => x.StockKey == stockKey);
            return JsonConvert.SerializeObject(result);
        }
    }
}