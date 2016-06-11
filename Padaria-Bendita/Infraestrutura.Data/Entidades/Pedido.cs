using System;
using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Pedido
    {
        public int CdPedido { get; set; }//PK

        public DateTime DtPedido { get; set; }
        public DateTime DtEntrega { get; set; }
        public decimal VlFrete { get; set; }
        public char TipEntrega { get; set; }
        public string CepEntrega { get; set; }
        public int NumEntrega { get; set; }
        public string complementoEntrega { get; set; }
        public int NumAPEntrega { get; set; }
        public decimal ValorTotal { get; set; }

        public int CdCliente { get; set; }//fk
        public int CdFunc { get; set; }//fk

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }

        public virtual ICollection<Pedidos_Produtos> Pedidos_Produtos { get; set; }
    }
}
