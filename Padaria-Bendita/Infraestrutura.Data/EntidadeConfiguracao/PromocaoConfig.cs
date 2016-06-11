using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class PromocaoConfig : EntityTypeConfiguration<Promocao>
    {
        public PromocaoConfig()
        {
            HasKey(pr => pr.CdPromo);//PK

            Property(pr => pr.NmPromo).HasMaxLength(45); // controle do tamanho maximo da variavel
            Property(pr => pr.DscPromo).HasMaxLength(200); // controle do tamanho maximo da variavel

            HasMany(pp => pp.Pedidos_Produtos)
                .WithRequired()
                .HasForeignKey(pp => pp.CdPromo);
        }
    }
}
