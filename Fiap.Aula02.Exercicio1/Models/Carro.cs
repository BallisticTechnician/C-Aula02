using System;
using System.Collections.Generic;
using System.Text;
namespace Fiap.Aula02.Exercicio1.Models
{
    public class Carro
    {
        //Propriedades
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Comprimento { get; set; }
        public Cor Cor { get; set; }
        public string Placa { get; set; }
        public bool ArCondicionado { get; set; }
        public decimal Valor { get; set; }
    }
}
