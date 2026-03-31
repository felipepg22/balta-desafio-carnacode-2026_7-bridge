using System;
using DesignPatternChallenge.Notifications.Image;
using DesignPatternChallenge.Notifications.Renderers;
using DesignPatternChallenge.Notifications.Text;
using DesignPatternChallenge.Notifications.Video;

namespace DesignPatternChallenge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Notificações Multi-Plataforma ===\n");

        var textNotification = new TextNotification("Novo Pedido", "Você tem um novo pedido");
        var imageNotification = new ImageNotification("Promoção", "50% de desconto!", "promo.jpg");
        var videoNotification = new VideoNotification("Tutorial", "Aprenda a usar o app", "tutorial.mp4");

        new WebRenderer(textNotification).Render();
        Console.WriteLine();

        new MobileRenderer(textNotification).Render();
        Console.WriteLine();

        new WebRenderer(imageNotification).Render();
        Console.WriteLine();

        new MobileRenderer(videoNotification).Render();
        Console.WriteLine();

        Console.WriteLine("=== BRIDGE ===");
        Console.WriteLine("✓ Tipo de notificação desacoplado da plataforma");
        Console.WriteLine("✓ Novo tipo: criar apenas 1 classe de notificação");
        Console.WriteLine("✓ Nova plataforma: criar apenas 1 renderer");
        Console.WriteLine("✓ Sem explosão combinatória de classes");
    }
}
