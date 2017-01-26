using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;
using System;

namespace prozorro.Model
{
    public static class DocumentDBClient
    {
        private static DocumentClient client;
        private static string databaseName;
        private static string collectionName;
        private static Uri DocumentCollectionUri;

        static DocumentDBClient()
        {
            //only for presentational purposes!
            client = new DocumentClient(new Uri("https://zorro-test.azurewebsites.net:443/"), "***");
            databaseName = "***";
            collectionName = "***";
            DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
        }
        public static DocumentClient DocumentClient()
        {
            return client;
        }
    }
}
