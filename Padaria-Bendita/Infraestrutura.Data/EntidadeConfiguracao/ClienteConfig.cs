using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class ClienteConfig:EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(cl => cl.CdCliente);//PK

            HasMany(pd => pd.Pedido)
               .WithRequired()
               .HasForeignKey(pd => pd.CdCliente);

            HasKey(cl => new { cl.CdPessoa, cl.CdPrioridade });//fk

        }
    }
}


