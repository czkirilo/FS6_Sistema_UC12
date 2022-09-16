using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

        public override double PagarImposto(float rendimento)
        {
            if (rendimento <= 5000){
                return rendimento * .06;
            } else if (rendimento > 5000 && rendimento <= 10000){
                return rendimento * .08;
            }else{
                return (rendimento/100) * 10;
            }
            //imposto de pessoa juridica...
            /*
            Para rendimentos até R$5.000,00- desconto de 6%
            Para rendimentos entre R$5.001,00 e R$10.000,00 - desconto de 8%
            Para rendimentos acima de R$10.000,01 - desconto de 10%
            */
        }

        public bool validarCNPJ(string cnpj){

            if ((cnpj.Length >= 14) && (cnpj.Substring(cnpj.Length - 4)) == "0001") {
                return true;
            }
                return false;
            
        }

        public void Inserir(PessoaJuridica pj){
            VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pj.Nome},{pj.cnpj},{pj.razaoSocial}"};

            File.AppendAllLines(caminho, pjString);
        }

        public List<PessoaJuridica> Ler(){
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas){
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }
}