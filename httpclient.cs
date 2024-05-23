var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, "https://api.bypass.vip/bypass?url=https://linkvertise.com/514008/hydrogen-gateway-1");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
