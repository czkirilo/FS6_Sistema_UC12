using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }

        public DateTime dataNasc { get; set; }
    }
}

// tudo o que vem do front é string, se quiser mudar tem que converter
