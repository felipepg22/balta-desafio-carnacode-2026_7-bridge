using System;

namespace DesignPatternChallenge
{
    public class ImageNotificationMobile : NotificationBase
    {
        private string imageUrl;

        public ImageNotificationMobile(string title, string content, string imageUrl)
            : base(title, content)
        {
            this.imageUrl = imageUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Mobile - Native] Rich Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Image: {imageUrl}");
            Console.WriteLine($"Style: BigPictureStyle");
        }
    }
}
