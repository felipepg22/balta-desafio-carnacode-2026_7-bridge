using System;

namespace DesignPatternChallenge.Notifications.Renderers;

public class WebRenderer : NotificationRenderer
{
    public WebRenderer(INotification notification) : base(notification)
    {
    }

    public override void Render()
    {
        notification.RenderWeb();
    }
}
