using System;
using System.Collections.Generic;


namespace Atividade6
{
    class Produto
    {
        public string Nome { get; set; }
        public double Produ { get; set; }

        public Produto(String nome, double produ)
        {
            Nome = nome;
            Produ = produ;
        }

        public override string ToString()
        {
            return Nome + "," + Produ.ToString("F2");
        }
    }
}
