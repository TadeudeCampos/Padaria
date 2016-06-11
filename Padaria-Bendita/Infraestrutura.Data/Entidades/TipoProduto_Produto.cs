

using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class TipoProduto_Produto
    {
        public int CdTipProduto { get; set; }//PFK
        public int CdProduto { get; set; }//PFK
        public int CdEmbalagem { get; set; }//PFK

        public virtual ICollection<TipoProduto> TipoProduto { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
        public virtual ICollection<Embalagem> Embalagem { get; set; }
    }
}
