using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var responseBodyAsString = await client.GetStringAsync("https://api.openbrewerydb.org/v1/breweries");


        }
    }
}
