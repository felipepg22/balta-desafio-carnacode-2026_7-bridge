using System;

namespace DesignPatternChallenge.Notifications.Renderers;

public class MobileRenderer : NotificationRenderer
{
    public MobileRenderer(INotification notification) : base(notification)
    {
    }

    public override void Render()
    {
        notification.RenderMobile();
    }
}
