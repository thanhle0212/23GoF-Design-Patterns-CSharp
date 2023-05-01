using System.Xml;
using Newtonsoft.Json;

namespace AdapterSample
{

    //Defining the Adapter that implements the Target interface
    public class StockXMLAdapter : IStockXMLTarget
    {
        public XmlDocument GetStockInformationXML(string stockKey)
        {
            StockJsonAdaptee stockAdaptee = new StockJsonAdaptee();
            string jsonStock = stockAdaptee.GetStockInformartion(stockKey);
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonStock, "StockInformation", true);
            return doc;
        }
    }
}