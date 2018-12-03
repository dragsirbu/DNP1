using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DogsApiClient
{
    class Client
    {
        private static readonly HttpClient myClient = new HttpClient();
        public string DogsUri { get; set; }
        public Client()
        {

        }

        public async Task<List<Dog>> ProcessDogsAsync()
        {
            myClient.DefaultRequestHeaders.Accept.Clear();
            myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var serializer = new DataContractJsonSerializer(typeof(List<Dog>));

            var streamTask = myClient.GetStreamAsync(DogsUri);

            var dogs = serializer.ReadObject(await streamTask) as List<Dog>;

            return dogs;
        }
    }
}
