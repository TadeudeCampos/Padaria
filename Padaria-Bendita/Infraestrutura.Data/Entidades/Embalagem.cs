using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Embalagem
    {
        public int CdEmbalagem { get; set; }//PK

        public string NmEmbalagem { get; set; }
        public string DscEmbalagem { get; set; }
        public string UnitEmbalagem { get; set; }

        public virtual ICollection<TipoProduto> TipoProduto { get; set; }

    }
}
