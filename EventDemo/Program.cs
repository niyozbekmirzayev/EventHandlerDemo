using EventDemo.Models;
using EventDemo.Services;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoEncoderService = new VideoEncoderService();
            var telegramService = new TelegramService();
            var mailService = new MailService();

            videoEncoderService.VideoEcoded += telegramService.OnVideoEncoded;
            videoEncoderService.VideoEcoded += mailService.OnVideoEncoded;

            var video = new Video
            {
                Name = "test.mp4",
                Size = 5
            };

            videoEncoderService.Encode(video);

            Console.WriteLine("Everything is ready");
        }
    }
}