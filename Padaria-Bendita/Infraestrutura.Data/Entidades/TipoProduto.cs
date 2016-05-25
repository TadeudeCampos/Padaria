using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
    class TipoProduto
    {
        public int CdTipProduto { get; set; }
        public string NmTipoProduto { get; set; }
        public string DsTipoProduto { get; set; }
        public DateTime DtValidade { get; set; }
        public int QantProdutoDisp { get; set; } //quantidade de produto disponivel  
        //Flags
        public string Cor { get; set; }
        public string ico { get; set; }

        public virtual Produto produto { get; set; }
    }
}
