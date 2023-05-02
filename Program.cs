using System;
using System.Net.Http;

namespace ApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var responseBodyAsString = client.GetStringAsync("https://api.openbrewerydb.org/v1/breweries");


        }
    }
}
