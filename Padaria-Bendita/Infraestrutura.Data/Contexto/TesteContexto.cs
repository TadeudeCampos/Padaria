using Infraestrutura.Data.EntidadeConfiguracao;
using Infraestrutura.Data.Migrations;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Contexto
{
    public class TesteContexto : DbContext
    {
        public TesteContexto() : base("ConnDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TesteContexto, Configuration>());
        }

        static TesteContexto()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(
                    properties =>
                        properties.ReflectedType != null && properties.Name == "Cd"+ properties.ReflectedType.Name )
                    .Configure(properties => properties.IsKey());
            modelBuilder.Configurations.Add(new CargoConfig());
            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EmbalagemConfig());
            modelBuilder.Configurations.Add(new FuncionarioConfig());
            modelBuilder.Configurations.Add(new LoteProdutosConfig());
            modelBuilder.Configurations.Add(new PedidoConfig());
            modelBuilder.Configurations.Add(new Pedidos_ProdutosConfig());
            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new PrioridadeConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new PromocaoConfig());
            modelBuilder.Configurations.Add(new TipoProduto_ProdutoConfig());
            modelBuilder.Configurations.Add(new TipoProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
