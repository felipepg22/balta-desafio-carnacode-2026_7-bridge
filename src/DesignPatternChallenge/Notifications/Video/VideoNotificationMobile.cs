using System;

namespace DesignPatternChallenge
{
    public class VideoNotificationMobile : NotificationBase
    {
        private string videoUrl;

        public VideoNotificationMobile(string title, string content, string videoUrl)
            : base(title, content)
        {
            this.videoUrl = videoUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Mobile - Native] Video Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Video: {videoUrl}");
            Console.WriteLine($"Action: Tap to play");
        }
    }
}
