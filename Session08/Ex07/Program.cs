using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Ex07
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

            string input;

            while (true)
            {
                Console.WriteLine("1) Change user name");
                Console.WriteLine("2) Change user email");
                Console.WriteLine("3) Delete user");
                Console.WriteLine("4) Add user");
            }
        }

        private static void ProcessRequest(int choice)
        {
            switch (choice)
            {
                case 1:
                {
                       
                }    
            }
        }

        private static void ChangeEmail()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter new email: ");
            string newEmail = Console.ReadLine();
            
        }
    }
}
