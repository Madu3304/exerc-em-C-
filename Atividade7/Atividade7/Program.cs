using System;
using Atividade7;
using System.Linq;
using System.Collections.Generic;

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


        // declarei que para cada elemneto da minha lista vai ser adicionado um NomeUpper, que retorna tudo em uma nova lista  em caixa alta. 
        List<string> resultado = list.Select(NomeUpper).ToList();
        foreach (string s in resultado)
        {
            Console.WriteLine(s);
        }
    }

    // Funçao qu recebe um nome de produtos e retorna ele em caixa alta depois. 
    static string NomeUpper(Produto p )
    {
        return p.Nome.ToUpper();
    }
}


; //aqui estou estudano oo delgate Func, com a utilizaçao do select do Using Linq.  

//############################################

//outra forma de fazer é usando o FUNC: 
// assim estou colocando o func ali e depois só chamando ele no Select(). 
//Func<Produto, string> func = NomeUpper;

//        List<string> resultado = list.Select(func).ToList();
//        foreach (string s in resultado)
//        {
//            Console.WriteLine(s);
//        }



//        static string NomeUpper(Produto p)
//        {
//            return p.Nome.ToUpper();
//        }


//############################################

// agora vou fazer usando o Lambda 


// nessa lambda não tem as'{}' pois esse lambda está retornndo valores. 
//Func<Produto, string> func = p => p.Nome.ToUpper();

//        List<string> resultado = list.Select(func).ToList();
//        foreach (string s in resultado)
//        {
//            Console.WriteLine(s);
//        }


//############################################

// agora vou fazer usando o "Lambda em Layne", que é colocar ela direto aqui no "List.Select()".

//        List<string> resultado = list.Select(p => p.Nome.ToUpper()).ToList();
//        foreach (string s in resultado)
//        {
//            Console.WriteLine(s);
//        }