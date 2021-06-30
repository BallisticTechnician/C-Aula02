
namespace Fiap.Aula02.Exemplo.Models
{
    public class Produto
    {
        //Atributos
        private int _id;

        //Getters e Setters (Propriedades)
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public Fabricante Fabricante { get; set; }

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }
        //Métodos
        //Calcular o valor do produto com desconto e retorna-lo calculado
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Valor - Valor * porcentagem / 100 ;

        }
        //O método abaixo, não recebe e não retorna nenhuma informação
        public void Cadastrar()
        {
            System.Console.WriteLine("Item sendo cadastrado...");
        }
    }
}
