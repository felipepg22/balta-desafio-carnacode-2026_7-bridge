using System;

namespace DesignPatternChallenge.Notifications.Video;

public class VideoNotification : INotification
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string VideoUrl { get; private set; }

    public VideoNotification(string title, string content, string videoUrl)
    {
        Title = title;
        Content = content;
        VideoUrl = videoUrl;
    }

    public void RenderWeb()
    {
        Console.WriteLine($"[Web - HTML] <div class='notification-video'>");
        Console.WriteLine($"  <video src='{VideoUrl}' controls></video>");
        Console.WriteLine($"  <h3>{Title}</h3>");
        Console.WriteLine($"  <p>{Content}</p>");
        Console.WriteLine("</div>");
    }

    public void RenderDesktop()
    {
        Console.WriteLine($"[Desktop - Toast] Windows Notification with Video:");
        Console.WriteLine($"╔══════════════════════════╗");
        Console.WriteLine($"║ ▶ {VideoUrl.Substring(0, Math.Min(20, VideoUrl.Length))}... ║");
        Console.WriteLine($"║ {Title.PadRight(24)} ║");
        Console.WriteLine($"║ {Content.PadRight(24)} ║");
        Console.WriteLine($"╚══════════════════════════╝");
    }

    public void RenderMobile()
    {
        Console.WriteLine($"[Mobile - Native] Video Push Notification:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Body: {Content}");
        Console.WriteLine($"Video: {VideoUrl}");
        Console.WriteLine($"Action: Tap to play");
    }
}
