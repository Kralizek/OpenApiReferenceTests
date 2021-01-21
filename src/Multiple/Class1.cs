using System;
using System.Net.Http;
using System.Threading.Tasks;
using TestAPI;

namespace Test
{
    public class Class1
    {
        public async Task DoSomething()
        {
            var http = new HttpClient();
            ITestClient testClient = new TestClient(http);
            
            var response = await testClient.EchoAsync(new Request { Message = "Hello World" });

            Console.WriteLine($"Received: {response.Message}");
        }
    }
}
