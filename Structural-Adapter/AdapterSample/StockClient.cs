using System.Xml;

namespace AdapterSample
{

    //Defining Client who will request the access to Adaptee
    public class StockClient
    {
        private IStockXMLTarget _stockXMLTarget;
        public StockClient(IStockXMLTarget stockXMLTarget)
        {
            _stockXMLTarget = stockXMLTarget;
        }

        public XmlDocument GetXMLStock(string stockKey)
        {
            return _stockXMLTarget.GetStockInformationXML(stockKey);
        }
    }
}