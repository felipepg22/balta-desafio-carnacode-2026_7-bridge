using System;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações Multi-Plataforma ===\n");

            // Problema: Precisamos de uma classe para cada combinação
            var textWeb = new TextNotificationWeb("Novo Pedido", "Você tem um novo pedido");
            textWeb.Render();
            Console.WriteLine();

            var textMobile = new TextNotificationMobile("Novo Pedido", "Você tem um novo pedido");
            textMobile.Render();
            Console.WriteLine();

            var imageWeb = new ImageNotificationWeb(
                "Promoção",
                "50% de desconto!",
                "promo.jpg"
            );
            imageWeb.Render();
            Console.WriteLine();

            var videoMobile = new VideoNotificationMobile(
                "Tutorial",
                "Aprenda a usar o app",
                "tutorial.mp4"
            );
            videoMobile.Render();
            Console.WriteLine();

            Console.WriteLine("=== PROBLEMAS ===");
            Console.WriteLine("✗ Explosão de classes: 3 tipos × 3 plataformas = 9 classes");
            Console.WriteLine("✗ Código duplicado entre classes similares");
            Console.WriteLine("✗ Adicionar novo tipo = criar 3 classes (uma por plataforma)");
            Console.WriteLine("✗ Adicionar nova plataforma = criar 3 classes (uma por tipo)");
            Console.WriteLine("✗ As duas hierarquias (tipo e plataforma) estão fortemente acopladas");
            Console.WriteLine();

            // Perguntas para reflexão:
            // - Como separar a abstração (tipo de notificação) da implementação (plataforma)?
            // - Como adicionar novos tipos de notificação sem criar classes para cada plataforma?
            // - Como adicionar novas plataformas sem modificar os tipos existentes?
            // - Como evitar a explosão combinatória de classes?
        }
    }
}
