using System;

namespace DesignPatternChallenge.Notifications.Renderers;

public class DesktopRenderer : NotificationRenderer
{
    public DesktopRenderer(INotification notification) : base(notification)
    {
    }

    public override void Render()
    {
        notification.RenderDesktop();
    }
}
