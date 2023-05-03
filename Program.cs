using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var responseBodyAsStream = await client.GetStreamAsync("https://api.openbrewerydb.org/v1/breweries");

            var items = await JsonSerializer.DeserializeAsync<List<Item>>(responseBodyAsStream);

           // foreach(var item in items)
           // {
           //     Console.WriteLine($"The task {item.text} was created on {item.created_at} and has a completion of {item.complete}");
          //  }
        }
    }
}
