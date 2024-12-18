using System;
using System.Runtime.ConstrainedExecution;

namespace CarteiraTest
{
     public class Program
    {

        //variavel 
        private int dinheiro = 50;

        public int Dinheiro { get; set; }
        
       
        //metodo
        public void Acrescentar(int valor)
        {
            //vai receber ela mesmo e o valor
            dinheiro += valor;
        }


        //metodo de tirar 
        public void Retirar(int valor)
        {
            //vai receber ela mesmo e tirar valor
            dinheiro -= valor;

        }

        public int MostrarDinheiro()
        {
            return dinheiro;
        }

        public void AlterarDinheiro(int num)
        {
            dinheiro = num;
        }

    }


}