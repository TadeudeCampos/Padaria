using Infraestrutura.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class LoteProdutosConfig:EntityTypeConfiguration<LoteProduto>
    {
        public LoteProdutosConfig()
        {
            HasKey(lp => lp.CdLote);//PK

            HasKey(pr => new { pr.CdProduto });//fk
        }     
    }
}
