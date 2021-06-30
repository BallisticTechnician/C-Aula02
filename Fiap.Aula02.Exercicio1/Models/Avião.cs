using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula02.Exercicio1.Models
{
    public class Avião
    {   
        //Propriedades
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Vomprimento { get; set; }
        public Cor Cor { get; set; }
        public string prefixo { get; set; }
        public double Horasvoo { get; set; }
        public decimal Valor { get; set; }
    }
}
