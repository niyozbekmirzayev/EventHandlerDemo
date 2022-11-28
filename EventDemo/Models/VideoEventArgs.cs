
namespace EventDemo.Models
{
    public class VideoEventArgs : EventArgs
    {
        public VideoEventArgs(Video video)
        {
            Video = video;
        }

        public Video Video { get; set; }
    }
}
