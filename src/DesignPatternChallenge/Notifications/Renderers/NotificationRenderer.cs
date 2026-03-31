using System;

namespace DesignPatternChallenge.Notifications.Renderers;

public abstract class NotificationRenderer
{
    protected readonly INotification notification;

    public NotificationRenderer(INotification notification)
    {
        this.notification = notification;
    }

    public abstract void Render();
}
