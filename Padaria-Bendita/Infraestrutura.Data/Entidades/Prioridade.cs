using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
   public class Prioridade
    {
        public int CdPrioridade { get; set; }//pk

        public char TipPrioridade { get; set; }
        public int PrioridadeCli { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
