using System;
using System.Globalization;

namespace EntradaDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome Completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa");
            int quantidadeQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço do Produto");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite seu ultimo Nome,idade e altura na mesma Linha:");
            string[] vect = Console.ReadLine().Split(' '); //Comando split para dividir em pedaços e colocar na mesma linha
            string ultimoNome = vect[0];
            int idade = int.Parse(vect[1]);
            double altura = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu nome Completo é:"+ nomeCompleto);
            Console.WriteLine("Quantidade de quartors é:"+ quantidadeQuarto);
            Console.WriteLine("Preco é:"+ Preco);
            Console.WriteLine("O ultimo nome é:" +ultimoNome);
            Console.WriteLine("idade é :"+ idade);
            Console.WriteLine("Minha altura é :"+ altura);
        }
    }
}
