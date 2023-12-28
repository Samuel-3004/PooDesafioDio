using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooDesafioDio.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public void Ligar()
        {
            Console.WriteLine($"Estou fazendo uma ligação do telefono: {Numero} .");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Estou recebendo uma ligação.");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}