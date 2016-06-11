using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class EmbalagemConfig:EntityTypeConfiguration<Embalagem>
    {
        public EmbalagemConfig()
        {
            HasKey(e => e.CdEmbalagem);//PK

            Property(e => e.NmEmbalagem).HasMaxLength(45); // controle do tamanho maximo da variavel
            Property(e => e.DscEmbalagem).HasMaxLength(200); // controle do tamanho maximo da variavel

            
        }
    }
}
