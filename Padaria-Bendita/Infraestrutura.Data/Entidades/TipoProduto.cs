

using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class TipoProduto
    {
        public int CdTipProduto { get; set; }//PK

        public string NmTipoProduto { get; set; }
        public string DscTipoProduto { get; set; }

        public virtual ICollection<TipoProduto_Produto> TipoProduto_Produto { get; set; }

    }
}
