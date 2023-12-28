using PooDesafioDio.Models;

namespace PooDesafioDio
{
  class Program
  {
    static void Main(String[] args)
    {
      Console.WriteLine("Smartphone: Iphone");
      Iphone smApple = new Iphone(numero: "123456789", modelo: "13s", imei: "454545", memoria: 48 );
      smApple.Ligar();
      smApple.ReceberLigacao();
      smApple.InstalarAplicativo(nome: "WhatsApp");

      Console.WriteLine("");
      
      Console.WriteLine("Smartphone: Nokia");
      Nokia smNokia = new Nokia(numero: "987654321", modelo: "Novo", imei: "#5454548", memoria: 10);
      smNokia.Ligar();
      smNokia.ReceberLigacao();
      smNokia.InstalarAplicativo(nome: "Facebook");
    
    }
  }
}

