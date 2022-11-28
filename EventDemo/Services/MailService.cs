
using EventDemo.Models;

namespace EventDemo.Services
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args) 
        {
            Console.WriteLine($"MailService: Sending an email with file called {args.Video.Name}...");
            Thread.Sleep(2000);
        }
    }
}
