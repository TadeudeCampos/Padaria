using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
   public class PedidoConfig:EntityTypeConfiguration<Pedido>
    {
        public PedidoConfig()
        {
            HasKey(pd => pd.CdPedido);//PK

            Property(pd => pd.CepEntrega).HasMaxLength(8); // controle do tamanho maximo da variavel

            HasMany(pp => pp.Pedidos_Produtos)
                .WithRequired()
                .HasForeignKey(pp => pp.CdPedido);

            HasKey(pd => new { pd.CdFunc, pd.CdCliente });//fk
        }
    }
}
