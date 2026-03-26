using System;

namespace DesignPatternChallenge
{
    public class ImageNotificationWeb : NotificationBase
    {
        private string imageUrl;

        public ImageNotificationWeb(string title, string content, string imageUrl)
            : base(title, content)
        {
            this.imageUrl = imageUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Web - HTML] <div class='notification-image'>");
            Console.WriteLine($"  <img src='{imageUrl}' />");
            Console.WriteLine($"  <h3>{title}</h3>");
            Console.WriteLine($"  <p>{content}</p>");
            Console.WriteLine("</div>");
        }
    }
}
