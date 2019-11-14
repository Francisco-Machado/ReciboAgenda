using System;
using System.Collections.Generic;
using System.Text;

namespace MachadosCore.Clientes
{
    public class Cliente : Gerenciador<Cliente>
    {
        public string NomeCompleto { get; set; }
        public int Valor { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public List<string> Entidade { get; set; }

        public List<string> AdicionarEntidade( List<string> NomeDaEntidade)
        {
            Entidade = new List<string>(NomeDaEntidade);

            return Entidade; 
        }

    }
}
