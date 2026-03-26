using System;

namespace DesignPatternChallenge
{
    public class TextNotificationMobile : NotificationBase
    {
        public TextNotificationMobile(string title, string content) : base(title, content) { }

        public override void Render()
        {
            Console.WriteLine($"[Mobile - Native] Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Icon: notification_icon.png");
        }
    }
}
