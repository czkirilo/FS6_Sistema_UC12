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


       public abstract double PagarImposto(float rendimento);

       public void VerificarPastaArquivo(string caminho)
       {
        string pasta = caminho.Split("/")[0];

        if(!Directory.Exists(pasta)){
            Directory.CreateDirectory(pasta);
        }

        if (!File.Exists(caminho)){
            using (File.Create(caminho)){
                
            }
        }
       }
    }
}