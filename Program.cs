using System;
using System.Collections.Generic;
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

            var responseBodyAsStream = await client.GetStreamAsync("https://official-joke-api.appspot.com/jokes/ten");

            var items = await JsonSerializer.DeserializeAsync<List<Item>>(responseBodyAsStream);

            foreach (var item in items)
            {
                Console.WriteLine($"{item.setup}\n");
                Console.WriteLine($"Punchline: {item.punchline}\n");

            }

        }


    }
}
