using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar entrada do usuário
            Console.Write("Digite a quantidade mínima: ");
            int quantMini = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade máxima: ");
            int quantMax = int.Parse(Console.ReadLine());

            // Criar um objeto da classe Ativi1
            Ativi1 estoque = new Ativi1(quantMini, quantMax);

            // Calcular o estoque médio e exibir
            double estoqueMedio = estoque.CalculaMedia();
            Console.WriteLine($"A média deste estoque é de: {estoqueMedio}");
        }
    }
}
;