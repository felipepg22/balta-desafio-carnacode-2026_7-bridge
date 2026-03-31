using System;

namespace DesignPatternChallenge.Notifications.Text;

public class TextNotification : INotification
{
    public string Title { get; private set; }

    public string Content { get; private set; }

    public TextNotification(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public void RenderDesktop()
    {
        Console.WriteLine($"[Desktop - Toast] Windows Notification:");
        Console.WriteLine($"╔══════════════════════════╗");
        Console.WriteLine($"║ {Title.PadRight(24)} ║");
        Console.WriteLine($"║ {Content.PadRight(24)} ║");
        Console.WriteLine($"╚══════════════════════════╝");
    }

    public void RenderMobile()
    {
        Console.WriteLine($"[Mobile - Native] Push Notification:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Body: {Content}");
        Console.WriteLine($"Icon: notification_icon.png");
    }

    public void RenderWeb()
    {
        Console.WriteLine($"[Web - HTML] <div class='notification'>");
        Console.WriteLine($"  <h3>{Title}</h3>");
        Console.WriteLine($"  <p>{Content}</p>");
        Console.WriteLine("</div>");
    }
}
