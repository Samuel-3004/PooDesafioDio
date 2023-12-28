using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooDesafioDio.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"O aplicativo {nome} foi instalado com sucesso no meu Iphone {Modelo}.");
        }
    }
}