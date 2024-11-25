using System;
using System.Collections.Generic;
using Atividade6;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("TV 58", 1050.00));
            list.Add(new Produto("TV", 980.00));
            list.Add(new Produto("Celular", 967.00));
            list.Add(new Produto("Conrole", 1000.00));
            list.Add(new Produto("Tablet", 150.00));
            list.Add(new Produto("HD", 5200.00));
            list.Add(new Produto("Mouse", 234.00));
            list.Add(new Produto("Mouse Pad", 80.00));

            list.ForEach(UpdateProduto);
            foreach( Produto p in list)
            {
                Console.WriteLine(p);
            }

        }

        static void UpdateProduto(Produto p)
        {
            p.Produ += p.Produ * 0.1;
        }
    }
}