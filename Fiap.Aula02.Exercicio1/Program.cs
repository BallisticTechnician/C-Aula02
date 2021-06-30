using System;
using Fiap.Aula02.Exercicio1.Models;
namespace Fiap.Aula02.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando objetos ou instanciando
            Avião aviao = new Avião();
            Carro carro = new Carro();
            Cor cor = new Cor();
            Lancha lancha = new Lancha();

            //Ler os dados
            Console.WriteLine("Digite o modelo do carro");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine("Digite o comprimento do carro");
            carro.Comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a placa do carro");
            carro.Placa = Console.ReadLine();
            Console.WriteLine("Digite o preço do carro");
            carro.Valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano do carro");
            carro.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("O carro possui ar condicionado?");
            carro.ArCondicionado = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor do carro");
            cor.Nome = Console.ReadLine();
            Console.WriteLine("Digite o R");
            cor.R = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o G");
            cor.G = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o B");
            cor.B = int.Parse(Console.ReadLine());

            //Atribuir a cor ao carro
            carro.Cor = cor;

            //Exibir os dados do carro
            Console.WriteLine($"Modelo : {carro.Modelo}; \nAno : {carro.Ano}; \nPlaca : {carro.Placa}; \nValor : {carro.Valor}; \nComprimento : {carro.Comprimento}; \nCor : {carro.Cor.Nome}; \nAr condicionado : {carro.ArCondicionado}; ");

        }
    }
}
