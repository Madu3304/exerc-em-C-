using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Atividade5
{
    public class Contrato
    {
        private string numeroContrato;
        private DateTime data;
        private double valor;
        private int parcelas;

        public Contrato(string numeroContrato, DateTime data, double valor, int parcelas)
        {
            this.numeroContrato = numeroContrato;
            this.data = data;
            this.valor = valor;
            this.parcelas = parcelas;
        }

        public List<Parcela> GerarParcelas()
        {
            List<Parcela> listaParcelas = new List<Parcela>();
            double valorBaseParcela = valor / parcelas; // Valor inicial sem juros e taxas

            for (int i = 1; i <= parcelas; i++)
            {
                // Juros simples de 1% por mês
                double juros = valorBaseParcela * 0.01 * i;
                // Taxa fixa de 2%
                double taxa = (valorBaseParcela + juros) * 0.02;
                double valorFinalParcela = valorBaseParcela + juros + taxa;

                DateTime dataParcela = data.AddMonths(i); // Cada parcela é um mês após o contrato
                listaParcelas.Add(new Parcela(i, dataParcela, valorFinalParcela));
            }

            return listaParcelas;
        }

    }
}
