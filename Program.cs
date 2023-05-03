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

            var responseBodyAsStream = await client.GetStreamAsync("https://dog.ceo/api/breeds/image/random");

            var items = await JsonSerializer.DeserializeAsync<Item>(responseBodyAsStream);



            Console.WriteLine($"Hello, this is not a TODO List, but if you want to see a random dog breed: ");
            Console.WriteLine($"{items.message} this has been a {items.status}! ");


        }
    }
}
