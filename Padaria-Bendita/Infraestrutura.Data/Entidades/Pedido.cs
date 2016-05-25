using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
    class Pedido
    {
        public int CdPedido { get; set; }
        public int QuantProduto { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
