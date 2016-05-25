using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Entidades
{
    class StatusProduto
    {
        public int CdStProduto { get; set; }
        public string NmStProduto { get; set; }
        public string DsStProduto { get; set; }
        //flags
        public string cor { get; set; }
        public string ico { get; set; }

    }
}
