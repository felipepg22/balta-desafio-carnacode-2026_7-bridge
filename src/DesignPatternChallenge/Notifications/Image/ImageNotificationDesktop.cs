using System;

namespace DesignPatternChallenge
{
    public class ImageNotificationDesktop : NotificationBase
    {
        private string imageUrl;

        public ImageNotificationDesktop(string title, string content, string imageUrl)
            : base(title, content)
        {
            this.imageUrl = imageUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Desktop - Toast] Windows Notification with Image:");
            Console.WriteLine($"╔══════════════════════════╗");
            Console.WriteLine($"║ [IMG: {imageUrl.Substring(0, Math.Min(15, imageUrl.Length))}...]  ║");
            Console.WriteLine($"║ {title.PadRight(24)} ║");
            Console.WriteLine($"║ {content.PadRight(24)} ║");
            Console.WriteLine($"╚══════════════════════════╝");
        }
    }
}
