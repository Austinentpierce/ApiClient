using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;


namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            //var currentDate = DateTime.Now;
            var responseBodyAsString = await client.GetStringAsync("https://official-joke-api.appspot.com/jokes/ten");
            //var items = await JsonDeserializeAsync<List<Item>>(responseBodyAsStreamTen);
            Console.WriteLine(responseBodyAsString);

        }


    }
}
