using System;
using System.Collections.Generic;


namespace Atividade7
{
    class Produto
    {
        //aqui os dados
        public string Nome { get; set; }
        public double Produ { get; set; }

        //método construtor  
        public Produto(String nome, double produ)
        {
            Nome = nome;
            Produ = produ;
        }


        // Declaração de um método público que sobrescreve o método ToString da classe base (Object).
        public override string ToString()
        {
            // ToString = é padrão em todas as classes do .NET, 
            return Nome + "," + Produ.ToString("F2");
            //O método ToString("F2") formata o valor numérico de Produ com 2 casas decimais,
        }
    }
}