using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(pr => pr.CdProduto);//PK

            Property(pr => pr.NmProduto).HasMaxLength(45); // controle do tamanho maximo da variavel
            Property(pr => pr.DscProduto).HasMaxLength(200); // controle do tamanho maximo da variavel

            HasMany(pp => pp.Pedidos_Produtos)
                .WithRequired()
                .HasForeignKey(pp => pp.CdProduto);

            HasMany(tpp => tpp.TipoProduto_Produto)
                .WithRequired()
                .HasForeignKey(tpp => tpp.CdProduto);

            HasMany(lp => lp.LoteProduto)
                .WithRequired()
                .HasForeignKey(lp => lp.CdProduto);

            HasKey(pr => new { pr.CdCategoria });//fk
        }
    }
}
