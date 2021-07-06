using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BypassVIP_API
{
    internal class Response
    {
        public bool success { get; set; }

        public string website { get; set; }

        public string query { get; set; }

        public string destination { get; set; }

        public bool cache { get; set; }

        public int time_ms { get; set; }
    }

    public static class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        public static void Main(string[] args)
        {
            Console.WriteLine(Post(args[0]).Result);
        }

        private static async Task<Response> Post(string url)
        {
            var values = new Dictionary<string, string>
            {
                {"url", url}
            };

            var response = await Client.PostAsync("https://api.bypass.vip/", new FormUrlEncodedContent(values));

            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Response>(responseString);
        }
    }
}
