using EventDemo.Models;

namespace EventDemo.Services
{
    public class VideoEncoderService
    {
        public event EventHandler<VideoEventArgs>? VideoEcoded;

        public void Encode(Video video) 
        {
            Console.WriteLine("Video encoding...");
            if(video.Size > 10) 
            {
                Thread.Sleep(5000);
            }
            else 
            {
                Thread.Sleep(2000);
            }

            OnVideoEcoded(video);
        }

        protected virtual void OnVideoEcoded(Video video) 
        {
            if(VideoEcoded != null)
            {
                var eventArgs = new VideoEventArgs(video);
                VideoEcoded.Invoke(this, eventArgs);
            }
        }
    }
}
