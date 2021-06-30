using Fiap.Aula02.Exemplo.Models;
using System;

namespace Fiap.Aula02.Exemplo
{
    class Program
     
    {
        static void Main(string[] args)
        {
            //Instanciar um produto
            Produto notebook = new Produto();

            //Instanciar um fabricante
            Fabricante fabricante = new Fabricante();
            fabricante.Nome = "Dell";

            //Atribuir o objeto fabricante no atributo do objeto produto
            notebook.Fabricante = fabricante;

            //Atribuir valores para os atributos
            notebook.Id = 10;
            notebook.Nome = "Dell XPS";
            notebook.Valor = 1000;
            notebook.Fabricante.Nome = "Dell";
            notebook.Fabricante.Ativo = false;
            notebook.Fabricante.Cnpj = "097.152.152.78";

            //Recuperar e exibir os valores dos atributos
            Console.WriteLine(notebook.Id);

            //Exibir o nome do fabricante e ver se ele esta ativo ou não
            Console.WriteLine($"{notebook.Fabricante.Nome} esta ativo : {notebook.Fabricante.Ativo}");

            //Calcular e exibir o valor do produto com 15% de desconto
            Console.WriteLine($"Valor de {notebook.CalcularDesconto(15)} ");
            //Instaciar um outro objeto Produto com outro valores nos atributos
            Produto mouse = new Produto();
            mouse.Nome = "Multilaser";
        }
    }
}
