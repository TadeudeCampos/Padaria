using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class Pedidos_ProdutosConfig : EntityTypeConfiguration<Pedidos_Produtos>
    {
        public Pedidos_ProdutosConfig()
        {
            HasKey(pp => new { pp.CdPedido, pp.CdProduto, pp.CdPromo });
        }
    }
}
