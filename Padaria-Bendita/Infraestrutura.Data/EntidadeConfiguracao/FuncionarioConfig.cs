using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class FuncionarioConfig : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig()
        {
            HasKey(f => f.CdFunc);//PK

            HasMany(pd => pd.Pedido)
               .WithRequired()
               .HasForeignKey(pd => pd.CdFunc);

            HasKey(f => new { f.CdPessoa, f.CdCargo });//fk
        }
    }
}
