
using EventDemo.Models;

namespace EventDemo.Services
{
    public class TelegramService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"TelegramService: Sending a message with file called {args.Video.Name}...");
            Thread.Sleep(2000);
        }
    }
}
