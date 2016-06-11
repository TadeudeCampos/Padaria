using System;
using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Produto
    {
        public int CdProduto{ get; set; } //PK

        public string NmProduto { get; set; }
        public string DscProduto { get; set; }
        public decimal VlUnit { get; set; }
        public int UnitEmEstoque { get; set; }
        public char NvlEstoque { get; set; }
        public char Descontinuado { get; set; }
        public int QtdMax { get; set; }
        public int QtdMin { get; set; }

        public int CdCategoria { get; set; } //FK

        public virtual ICollection<Categoria> Categoria { get; set; }

        public virtual ICollection<Pedidos_Produtos> Pedidos_Produtos { get; set; }
        public virtual ICollection<TipoProduto_Produto> TipoProduto_Produto { get; set; }
        public virtual ICollection<LoteProduto> LoteProduto { get; set; }


    }
}
