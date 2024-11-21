using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Ativi2
    {
        private double valorDolar;

        //construtor
        public Ativi2 (double valorDolar)
        { 
            this.valorDolar = valorDolar;
        }


        //metodo
        public double Calcular()
        {
            return valorDolar / 5.0;
        }

    }
} 