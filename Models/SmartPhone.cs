using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooDesafioDio.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public void Ligar()
        {
            Console.WriteLine($"Estou fazendo uma ligação do telefone de número {Numero}.");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Estou recebendo uma ligação.");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}