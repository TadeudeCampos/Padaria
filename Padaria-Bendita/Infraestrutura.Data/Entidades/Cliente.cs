

using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Cliente
    {
        public int CdCliente { get; set; }//PK

        public string StCliente { get; set; }

        public int CdPessoa { get; set; }//FK
        public int CdPrioridade { get; set; }//FK

        public virtual ICollection<Pessoa> Pessoa { get; set; }
        public virtual ICollection<Prioridade> Prioridade { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }

    }
}
