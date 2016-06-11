

using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Categoria
    {
        public int CdCategoria { get; set; }//PK

        public string NmCategoria { get; set; }
        public string DscCategoria { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
