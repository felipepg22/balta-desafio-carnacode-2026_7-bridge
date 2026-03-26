using System;

namespace DesignPatternChallenge
{
    public class TextNotificationDesktop : NotificationBase
    {
        public TextNotificationDesktop(string title, string content) : base(title, content) { }

        public override void Render()
        {
            Console.WriteLine($"[Desktop - Toast] Windows Notification:");
            Console.WriteLine($"╔══════════════════════════╗");
            Console.WriteLine($"║ {title.PadRight(24)} ║");
            Console.WriteLine($"║ {content.PadRight(24)} ║");
            Console.WriteLine($"╚══════════════════════════╝");
        }
    }
}
