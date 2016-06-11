using Infraestrutura.Data.Contexto;
using Infraestrutura.Data.Entidades;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Migrations
{
   public class Configuration : DbMigrationsConfiguration<TesteContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("Mysql.Data.MySqlCliente", new MySqlMigrationSqlGenerator());
            CodeGenerator = new MySqlMigrationCodeGenerator();
        }

        protected override void Seed(TesteContexto context)
        {
            context.Set<Pessoa>().AddOrUpdate(e => e.CdPessoa,
                    new Pessoa { CdPessoa = 1, NmPessoa = "Adm", Senha = "Adm" }
            );
        }
    }
}
