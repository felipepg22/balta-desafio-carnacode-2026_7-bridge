using System;

namespace DesignPatternChallenge
{
    public class VideoNotificationWeb : NotificationBase
    {
        private string videoUrl;

        public VideoNotificationWeb(string title, string content, string videoUrl)
            : base(title, content)
        {
            this.videoUrl = videoUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Web - HTML] <div class='notification-video'>");
            Console.WriteLine($"  <video src='{videoUrl}' controls></video>");
            Console.WriteLine($"  <h3>{title}</h3>");
            Console.WriteLine($"  <p>{content}</p>");
            Console.WriteLine("</div>");
        }
    }
}
