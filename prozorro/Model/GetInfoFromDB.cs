using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace prozorro.Model
{
    class GetInfoFromDB
    {
        public void GetInfoAboutAuctionFromDB()
        {
            //connection to DB
            string databaseName = "***";
            string collectionName = "***";
            var DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);
            //recieve document
            var doc = DocumentDBClient.DocumentClient().CreateDocumentQuery<object>(DocumentCollectionUri, @"select * from c where c.id = ""557f6127-c56b-47cd-9bfd-9639bc1516cb""")
                .ToList()
                .FirstOrDefault();
            //json document treatment
            var json = JObject.Parse(doc.ToString());
            //get id field from document
            var idFromAzureDB = json.SelectToken("id").Value<string>();
        }
    }
}
