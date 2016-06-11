using Infraestrutura.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Data.EntidadeConfiguracao
{
    public class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(pe => pe.CdPessoa);//Pk

            Property(pe => pe.NmPessoa).HasMaxLength(45); // controle do tamanho maximo da variavel
            Property(pe => pe.CEP).HasMaxLength(8); // controle do tamanho maximo da variavel
            Property(pe => pe.CPF).HasMaxLength(11);
            Property(pe => pe.Telefone).HasMaxLength(14);

            HasMany(f => f.Funcionario)
                .WithRequired()
                .HasForeignKey(f => f.CdPessoa);

            HasMany(cl => cl.Cliente)
               .WithRequired()
               .HasForeignKey(cl => cl.CdPessoa);
        }
    }
}
