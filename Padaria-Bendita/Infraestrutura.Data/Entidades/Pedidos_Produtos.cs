

using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Pedidos_Produtos
    {
        public decimal VlUnit { get; set; }
        public int Qtd { get; set; }
        public decimal Desconto { get; set; }
        public int UnitPedidas { get; set; }

        public int CdPedido { get; set; }//PFK
        public int CdProduto { get; set; }//PFK
        public int CdPromo { get; set; }//PFK

        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
        public virtual ICollection<Promocao> Promocao { get; set; }

    }
}
