using System.Net.Http;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncConsole
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
            WriteLine($"Apple's homepage has {response.Content.Headers.ContentLength:N0} bytes.");
            ReadLine();
        }
    }
}
