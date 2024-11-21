//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// Faça um programa para calcular o estoque médio de uma peça, sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

//namespace Atividade1
//{
//    public class Ativi1
//    {
//        private int quantMini = 0;
//        private int quantMax = 1000;
//        private int quantTotal = 0;

//        public Ativi1(int quantMini, int quantMax, int quantTotal)
//        {
//            this.quantMini = quantMini;
//            this.quantMax = quantMax;
//            this.quantTotal = quantTotal;
//        }
//    }
//}


using System;

namespace Atividade1
{
    public class Ativi1
    {
        private int quantMini;
        private int quantMax;

      //construtor
        public Ativi1(int quantMini, int quantMax)
        {
            this.quantMini = quantMini;
            this.quantMax = quantMax;
        }

        // Método 
        public double CalculaMedia()
        {
            return (quantMini + quantMax) / 2.0; 
        }
    }
}
