using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class Pessoa
    {
       public string? Nome { get; set; }
       public Endereco? endereco { get; set; }


       public abstract void PagarImposto(float rendimento);
    }
}