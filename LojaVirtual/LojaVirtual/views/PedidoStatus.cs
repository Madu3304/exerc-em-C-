﻿using System;
using System.Collections.Generic;

namespace LojaVirtual.views.Enums
{
    enum PedidoStatus : int
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3,
    }
}