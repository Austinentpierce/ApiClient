using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = newHttpClient();
            var currentDate = DateTime.Now;
            var responseBodyAsStreamTen = await client.GetStreamAsync("https://official-joke-api.appspot.com/jokes/ten");
            var items = await JsonDeserializeAsync<List<Item>>(responseBodyAsStreamTen);


        }


    }
}
