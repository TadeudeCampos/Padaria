using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
    class Cliente
    {
        public int CdCliente { get; set; }
        public string NmCliente { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
    }
}
