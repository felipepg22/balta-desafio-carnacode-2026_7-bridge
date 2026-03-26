using System;

namespace DesignPatternChallenge
{
    public class TextNotificationWeb : NotificationBase
    {
        public TextNotificationWeb(string title, string content) : base(title, content) { }

        public override void Render()
        {
            Console.WriteLine($"[Web - HTML] <div class='notification'>");
            Console.WriteLine($"  <h3>{title}</h3>");
            Console.WriteLine($"  <p>{content}</p>");
            Console.WriteLine("</div>");
        }
    }
}
