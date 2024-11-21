//using System;

//namespace Program
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Deseja ler o material? ");

//            switch (s/n)
//            {
//                case 1: ("s")
//                Console.WriteLine("a seguir conteúdo do arquivo selecionado");
//            break;

//              case 2: ("n")
//              Console.WriteLine("Este arquivo não será lido");
//            break;

//            default:
//                Console.WriteLine("escolha uma opção");

//        }
//    }
//}

using System;
using atividade3;

namespace ProgramNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja ler o material? (s/n)");
            string resposta = Console.ReadLine()?.ToLower();

            switch (resposta)
            {
                case "s":
                    Ativi3.LerArquivo();
                    break;

                case "n":
                    Console.WriteLine("Operação cancelada pelo usuário.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
