using System;
using Atividade2;

namespace Ativi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em Dolar que você tem: ");
            double valorDolar = double.Parse(Console.ReadLine());

            //criando obj
            Ativi2 converter = new Ativi2(valorDolar);

            //calcular
            double real = converter.Calcular();
            Console.WriteLine($"Esse valor em Real é: {real}");
        }   
    }
}