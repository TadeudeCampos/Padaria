
using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Funcionario
    {
        public int CdFunc { get; set; }//PK

        public int StFunc { get; set; }

        public int CdPessoa { get; set; }//FK
        public int CdCargo { get; set; }//FK

        public virtual ICollection<Pessoa> Pessoa { get; set; }
        public virtual ICollection<Cargo> Cargo { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
