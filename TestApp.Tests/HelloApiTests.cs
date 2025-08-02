using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace TestApp.Tests
{
    [TestFixture]
    public class HelloApiTests
    {
        private static readonly HttpClient client = new HttpClient();
        private string _baseUrl = "https://localhost:44311";
        [Test]
        public async Task TestMessageController()
        {
            // Replace with the correct port your API runs on 

            var response = await client.GetAsync($"{_baseUrl}/api/hello");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(content);

            Assert.That(json["message"]?.ToString(), Is.EqualTo("hello1"));
        }
        [Test]
        public async Task TestMessage2Controller()
        {
            // Replace with the correct port your API runs on 

            var response = await client.GetAsync($"{_baseUrl}/api/hello");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(content);

            Assert.That(json["message"]?.ToString(), Is.EqualTo("hello"));
        }
    }
}
