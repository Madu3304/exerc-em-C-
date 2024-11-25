using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Atividade5
{
    public class Parcela
    {
            public int Numero { get; private set; }
            public DateTime DataVencimento { get; private set; }
            public double Valor { get; private set; }

            public Parcela(int numero, DateTime dataVencimento, double valor)
            {
                Numero = numero;
                DataVencimento = dataVencimento;
                Valor = valor;
            }

            public override string ToString()
            {
                return $"Parcela {Numero}: Vencimento {DataVencimento:dd/MM/yyyy} - Valor: {Valor:C}";
            }
    }
}

