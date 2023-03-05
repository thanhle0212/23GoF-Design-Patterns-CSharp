namespace PrototypeSample
{
    public class ServerConfiguration: IPrototype
    {
        public string FileStorageURL {get;set;}
        public string OperationSystem {get;set;}
        private string DBConnection {get;set;}

        public object Clone()
        {
            var clone = new ServerConfiguration(){
                FileStorageURL = this.FileStorageURL,
                OperationSystem = this.OperationSystem,
                // This can be changed by implementation logic
                DBConnection = "This is private connection!"
            };
            return clone;
        }

        // Print object details
        public string GetDetails()
        {
            return $"Storage URL : {this.FileStorageURL} - OS: {this.OperationSystem} - DB Connection: {this.DBConnection}";
        }
    }
}