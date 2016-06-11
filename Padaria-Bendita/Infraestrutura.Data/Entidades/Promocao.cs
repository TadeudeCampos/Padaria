using System;
using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Promocao
    {
        public int CdPromo { get; set; }//PK

        public string NmPromo { get; set; }
        public DateTime DtIniPromo { get; set; }
        public DateTime DtFimPromo { get; set; }
        public string DscPromo { get; set; }
        public int QtdMinPromo { get; set; }
        public int QtdMaxPromo { get; set; }

        public virtual ICollection<Pedidos_Produtos> Pedidos_Produtos { get; set; }
    }
}
