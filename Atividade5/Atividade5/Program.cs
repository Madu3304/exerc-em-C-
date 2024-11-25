using System;
using System.Collections.Generic;
using static Atividade5.Servico;

namespace Program
{
    class Program
    {

        //static void Main(String[] args)
        //{

        //    Console.WriteLine("Digite o número do contrato:  ");
        //    String Contrato = Console.ReadLine()?.ToLower();

        //    Console.WriteLine("Digite data de inicio do contrato:  ");
        //    DateTime Contratohora = (DateTime.Parse) Console.ReadLine();

        //    Console.WriteLine("Digite o Valor do contrato:  ");
        //    int Contratovalor = (int.Parse) Console.ReadLine();

        //    Console.WriteLine("Digite o número de parcelas do contrato:  ");
        //    String Contratoparce = Console.ReadLine()?.ToLower();

        //}

        // AQUI ESTOU SOLICITANDO OS DADOS PARA O SISTEMA REALIZAR O PROCESSO.
        // Leitura dos dados do contrato
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do contrato: ");
            string Contrato = Console.ReadLine()?.ToLower();

            Console.WriteLine("Digite a data de início do contrato (formato: dd/MM/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime Contratohora))
            {
                // Data válida
            }
            else
            {
                Console.WriteLine("Data inválida! Digite novamente.");
                return; // Sai do programa se a data for inválida
            }

            Console.WriteLine("Digite o valor do contrato: ");
            if (int.TryParse(Console.ReadLine(), out int Contratovalor))
            {
                // Valor válido
            }
            else
            {
                Console.WriteLine("Valor inválido! Digite novamente.");
                return; // Sai do programa se o valor for inválido
            }

            Console.WriteLine("Digite o número de parcelas do contrato: ");
            string Contratoparce = Console.ReadLine()?.ToLower(); // O número de parcelas é string, conforme solicitado

            // Exemplo de exibição das informações para confirmar o armazenamento:
            Console.WriteLine("\nDados do novo contrato:");
            Console.WriteLine($"Número do contrato: {Contrato}");
            Console.WriteLine($"Data de início: {Contratohora:dd/MM/yyyy}");
            Console.WriteLine($"Valor do contrato: {Contratovalor}");
            Console.WriteLine($"Número de parcelas: {Contratoparce}");


            // Criação do contrato
            var contratofinal = new Contrato(numero, data, valor, parcelas);

            // Exibir das parcelas
            List<Parcela> listaParcelas = contratofinal.GerarParcelas();

            Console.WriteLine("\nParcelas do contrato:");
            foreach (var parcela in listaParcelas)
            {
                Console.WriteLine(parcela);
            }
        }
    }
}



