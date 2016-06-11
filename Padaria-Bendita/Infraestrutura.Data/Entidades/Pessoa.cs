

using System.Collections.Generic;

namespace Infraestrutura.Data.Entidades
{
    public class Pessoa
    {
        public int CdPessoa { get; set; }//PK

        public string NmPessoa { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public int NumAP { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Funcionario> Funcionario { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
