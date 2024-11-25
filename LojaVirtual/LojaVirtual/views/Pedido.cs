using System;
using LojaVirtual.views;
using LojaVirtual.views.Enums;

namespace LojaVirtual.views
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; } 
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return Id
            + ","
            + Moment.ToString()
            + ","
            + Status.ToString();
        }

    }
}
