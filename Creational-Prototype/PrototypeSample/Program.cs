// See https://aka.ms/new-console-template for more information
using PrototypeSample;

ServerConfiguration config = new ServerConfiguration();
config.FileStorageURL = "https://google.com/drive/";
config.OperationSystem = "Windows Server 2019";

var clonedConfig = (ServerConfiguration)config.Clone();

Console.WriteLine(clonedConfig.GetDetails());


Employee developer = new Employee();
developer.FirstName = "Thanh";
developer.LastName = "Le";

var clonedDeveloper = (Employee)developer.Clone();

Console.WriteLine(clonedDeveloper.GetDetails());

