using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class TipoProdutoConfig : EntityTypeConfiguration<TipoProduto>
    {
        public TipoProdutoConfig()
        {
            HasKey(tp => tp.CdTipProduto);//PK

            Property(tp => tp.NmTipoProduto).HasMaxLength(45); // controle do tamanho maximo da variavel
            Property(tp => tp.DscTipoProduto).HasMaxLength(200); // controle do tamanho maximo da variavel

            HasMany(tpp => tpp.TipoProduto_Produto)
                .WithRequired()
                .HasForeignKey(tpp => tpp.CdTipProduto);
        }
    }
}
