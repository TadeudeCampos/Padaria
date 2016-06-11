using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
    public class Cargo
    {
        public int CdCargo { get; set; }//PK

        public string NmCargo { get; set; }
        public string DscCargo { get; set; }

        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
