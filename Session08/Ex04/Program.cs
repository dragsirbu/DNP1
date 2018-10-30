using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        private static async Task<List<User>> ProcessUsersAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent","Users Name and Email Reporter");

            var serializer = new DataContractJsonSerializer(typeof(List<User>));

            var streamTask = client.GetStreamAsync("https://jsonplaceholder.typicode.com/users");
            var users = serializer.ReadObject(await streamTask) as List<User>;

            return users;
        }
        static void Main(string[] args)
        {
            var users = ProcessUsersAsync().Result;

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Email);
                Console.WriteLine();
            }
        }
    }
}
