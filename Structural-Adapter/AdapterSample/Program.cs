using AdapterSample;
internal class Program
{
    private static void Main(string[] args)
    {
        StockXMLAdapter xmlAdapter = new StockXMLAdapter();
        StockClient stockClient = new StockClient(xmlAdapter);
        var xmlResult = stockClient.GetXMLStock("MSFT");


        Console.WriteLine(xmlResult.OuterXml);
    }
}