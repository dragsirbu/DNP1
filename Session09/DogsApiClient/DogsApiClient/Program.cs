using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace DogsApiClient
{
    class Program
    {

        private static readonly HttpClient client = new HttpClient();
        public static async Task<List<Dog>> ProcessDogsAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var serializer = new DataContractJsonSerializer(typeof(List<Dog>));

            var streamTask = client.GetStreamAsync("https://localhost:5001/api/dogs");

            var dogs = serializer.ReadObject(await streamTask) as List<Dog>;

            return dogs;
        }


        static void Main(string[] args)
        {
            //Client client = new Client();
            //client.DogsUri = "https://localhost:5001/api/dogs";
            var dogs = ProcessDogsAsync().Result;

            Console.WriteLine("Dog info:\n");

            foreach (var dog in dogs)
            { 
                Console.WriteLine(dog.Id);
                Console.WriteLine(dog.Name);
                Console.WriteLine(dog.Breed);
                Console.ReadKey();
            }
        }
    }
}
