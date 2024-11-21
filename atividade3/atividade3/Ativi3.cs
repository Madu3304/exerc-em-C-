//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace atividade3
//{
//    public class Ativi3
//    {
//        public static void Main()
//        {
//            FileStream fs = null;
//            try
//            {
//                fs = new FileStream(@"C:\Duda Teste\system em c#.txt", FileMode.Open);
//                StreamReader sr = new StreamReader(fs);
//                string line = sr.ReadLine();
//                Console.WriteLine(line);
//            }

//            catch (FileNotFoundException e) {
//                Console.WriteLine(e.Message);
//            } 

//            finally {
//                if (fs != null)
//                {
//                    fs.Close();
//                }
//            }
//        } 
//    }
//}


using System;
using System.IO;
using System.Collections.Generic;

namespace atividade3
{
    public class Ativi3
    {
        public static void LerArquivo()
        {
            try
            {
                // Caminho do arquivo
                string caminho = @"C:\Duda Teste\system em c#.txt";

                // Verifica se o arquivo existe
                if (!File.Exists(caminho))
                {
                    Console.WriteLine("Arquivo não encontrado!");
                    return;
                }

                // Lê e exibe o conteúdo do arquivo
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }

        }
    }
}
