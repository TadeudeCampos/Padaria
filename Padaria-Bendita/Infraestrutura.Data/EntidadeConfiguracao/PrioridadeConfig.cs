using Infraestrutura.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class PrioridadeConfig:EntityTypeConfiguration<Prioridade>
    {
        public PrioridadeConfig()
        {
            HasKey(prd => prd.CdPrioridade);//Pk

            HasMany(cl => cl.Cliente)
                .WithRequired()
                .HasForeignKey(cl => cl.CdPrioridade);
        }
    }
}
