using System;
using LojaVirtual.views.Enums;

namespace Program{

    class Pedido{
        static void Main(string[] args)
        {
            //Pedido == pedido 
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = PedidoStatus.PagamentoPendente
            };

            Console.WriteLine(pedido);

            string txt = PedidoStatus.PagamentoPendente.ToString();
            Console.WriteLine(txt);


            //aqui vou converter para string
            PedidoStatus os = Enum.Parse<PedidoStatus>("Entregue");
            Console.WriteLine(os);
        }
    }
}