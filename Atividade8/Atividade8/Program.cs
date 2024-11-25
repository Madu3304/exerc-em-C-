//estudndo o linq e suas funcionalidades. 

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace rogram
{
     class Program
    {
        static void Main(string[] args)
        {

            //banco, usando um vetor de numeros 
            int[] numero = new int[] { 2, 3, 4, 5, 6, 8, 13, 10, 14, 16, 18, 22 };


            // definir a consulta. "WHERE" aqui é para filtrar.
            // (x % 2 == 0 vai dar verddadeiro somente para números pares).
            var resultado = numero.Where(x => x % 2 == 0).Select(x => x * 10);
            // aqui Select(x => x * 10) o resultao anterior vai ser multiplicado por 10.


            // executar a consulta
            foreach (int x in resultado)
            {
                Console.WriteLine(x);
            }
        }
    }
}