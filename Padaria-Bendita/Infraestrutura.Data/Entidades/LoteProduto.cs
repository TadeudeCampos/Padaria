using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
    public class LoteProduto
    {
        public int CdLote { get; set; }//PK

        public DateTime DtFabricacao { get; set; }
        public DateTime DtValidade { get; set; }

        public int CdProduto { get; set; } // FK

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
