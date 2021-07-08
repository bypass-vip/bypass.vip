using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BypassVIP_API
{
    internal class Response
    {
        public bool Success { get; set; }
        public string Website { get; set; }
        public string Query { get; set; }
        public string Destination { get; set; }
        public bool Cache { get; set; }
        public int TimeMs { get; set; }
    }

    public static class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        public static void Main(string[] args)
        {
            var result = Bypass("URL").Result;
            
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Website);
            Console.WriteLine(result.Query);
            Console.WriteLine(result.Destination);
            Console.WriteLine(result.Cache);
            Console.WriteLine(result.TimeMs);
        }

        private static async Task<Response> Bypass(string url)
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
