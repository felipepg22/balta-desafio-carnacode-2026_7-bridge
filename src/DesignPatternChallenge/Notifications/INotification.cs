using System;

namespace DesignPatternChallenge.Notifications;

public interface INotification
{
    string Title {get;}
    string Content {get; }

   public void RenderWeb();
   public void RenderDesktop();
   public void RenderMobile();

}
