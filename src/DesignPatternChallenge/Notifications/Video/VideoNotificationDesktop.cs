using System;

namespace DesignPatternChallenge
{
    public class VideoNotificationDesktop : NotificationBase
    {
        private string videoUrl;

        public VideoNotificationDesktop(string title, string content, string videoUrl)
            : base(title, content)
        {
            this.videoUrl = videoUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Desktop - Toast] Windows Notification with Video:");
            Console.WriteLine($"╔══════════════════════════╗");
            Console.WriteLine($"║ ▶ {videoUrl.Substring(0, Math.Min(20, videoUrl.Length))}... ║");
            Console.WriteLine($"║ {title.PadRight(24)} ║");
            Console.WriteLine($"║ {content.PadRight(24)} ║");
            Console.WriteLine($"╚══════════════════════════╝");
        }
    }
}
