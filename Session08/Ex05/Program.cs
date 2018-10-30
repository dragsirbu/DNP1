using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        private static async Task DownloadPageAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Download-Agent","VIA Homepage");

            var stringTask = client.GetStringAsync("http://www.via.dk");

            var content = await stringTask;

            Console.WriteLine(content);
        }
        
        
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            DownloadPageAsync().Wait();
            
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"\nTime to download: {elapsedMs} ms.");
        }
    }
}
