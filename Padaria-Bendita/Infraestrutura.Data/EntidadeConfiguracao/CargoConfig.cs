using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class CargoConfig:EntityTypeConfiguration<Cargo>
    {
        public CargoConfig()
        {
            HasKey(ca => ca.CdCargo);//PK

            Property(ca => ca.NmCargo).HasMaxLength(45); // controle do tamanho maximo da variavel
            Property(ca => ca.DscCargo).HasMaxLength(200); // controle do tamanho maximo da variavel

            HasMany(f => f.Funcionario)
                .WithRequired()
                .HasForeignKey(f => f.CdCargo);
        }
    }
}
