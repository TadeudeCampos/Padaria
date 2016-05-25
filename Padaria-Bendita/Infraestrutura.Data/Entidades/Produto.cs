using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
    class Produto
    {
        public int CdProduto{ get; set; }
        public string NmProduto { get; set; }
        public string DscProduto { get; set; }
        public decimal VlUnitario { get; set; }
        public DateTime DtProdução { get; set; }

        //FK
       // public IEnumerable<TipoProduto> _TipoProduto { get; set; }
        public int CdStProduto { get; set; }
        public int CdStValidade { get; set; }


    }
}
