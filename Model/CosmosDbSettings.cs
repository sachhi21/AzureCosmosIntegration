namespace AzureCosmosIntegration.Model
{
    public class CosmosDbSettings
    {
        

        public required string connectionString { get; set; }
        public required string databaseName { get; set; }
    }
}
