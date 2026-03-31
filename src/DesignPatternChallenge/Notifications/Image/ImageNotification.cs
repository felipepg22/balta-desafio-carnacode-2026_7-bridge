using System;

namespace DesignPatternChallenge.Notifications.Image;

public class ImageNotification : INotification
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string ImageUrl { get; private set; }

    public ImageNotification(string title, string content, string imageUrl)
    {
        Title = title;
        Content = content;
        ImageUrl = imageUrl;
    }

    public void RenderWeb()
    {
        Console.WriteLine($"[Web - HTML] <div class='notification-image'>");
        Console.WriteLine($"  <img src='{ImageUrl}' />");
        Console.WriteLine($"  <h3>{Title}</h3>");
        Console.WriteLine($"  <p>{Content}</p>");
        Console.WriteLine("</div>");
    }

    public void RenderDesktop()
    {
        Console.WriteLine($"[Desktop - Toast] Windows Notification with Image:");
        Console.WriteLine($"╔══════════════════════════╗");
        Console.WriteLine($"║ [IMG: {ImageUrl.Substring(0, Math.Min(15, ImageUrl.Length))}...]  ║");
        Console.WriteLine($"║ {Title.PadRight(24)} ║");
        Console.WriteLine($"║ {Content.PadRight(24)} ║");
        Console.WriteLine($"╚══════════════════════════╝");
    }

    public void RenderMobile()
    {
        Console.WriteLine($"[Mobile - Native] Rich Push Notification:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Body: {Content}");
        Console.WriteLine($"Image: {ImageUrl}");
        Console.WriteLine($"Style: BigPictureStyle");
    }
}
