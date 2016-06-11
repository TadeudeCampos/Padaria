using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class TipoProduto_ProdutoConfig:EntityTypeConfiguration<TipoProduto_Produto>
    {
        public TipoProduto_ProdutoConfig()
        {
            HasKey(tpp => new { tpp.CdTipProduto, tpp.CdProduto, tpp.CdEmbalagem });//fk
        }
    }
}
