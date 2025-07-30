
using DesafioPOO.Models;

namespace Projeto_Celular
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia("11999999999", "Nokia 3310", "1234567890", 123);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\nSmartphone Iphone:");
            Smartphone iphone = new Iphone("11988888888", "Iphone 12", "0987654321", 256);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp2");

        }
    }
}