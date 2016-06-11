using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class CategoriaConfig:EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            HasKey(ca => ca.CdCategoria);//PK

            Property(ca => ca.NmCategoria).HasMaxLength(45); // controle do tamanho maximo da variavel
            Property(ca => ca.DscCategoria).HasMaxLength(200);

            HasMany(pr => pr.Produto) //saeleciona o nome da tabela 
                .WithRequired()
                .HasForeignKey(pr => pr.CdCategoria);//informa o campo correspondente
        }
    }
}
