namespace Sistema{
    class Program{
        static void Main(string[] args)
        {
        Endereco banana = new Endereco();
        banana.logradouro = "Rua X";
        banana.numero = 100;
        banana.complemento = "Perto do senai";
        banana.enderecoComercial = true;

        PessoaJuridica Paralelepipedo = new PessoaJuridica();
        Paralelepipedo.cnpj = "1618716187";

        PessoaJuridica LC = new PessoaJuridica();
        LC.endereco = banana;
        LC.cnpj = "1235678990001";
        LC.razaoSocial = "Pessoa Juridica";

       bool cnpjvalidado = LC.validarCNPJ(LC.cnpj);
       
       if(cnpjvalidado == true){
        Console.WriteLine("Verdadeiro - O CNPJ é valido");
       }else{
        Console.WriteLine("Falso - O CNPJ");
       }



       // PessoaFisica Lucas = new PessoaFisica();
       // Lucas.endereco = end;
       // Lucas.cpf = "12345678";
       // Lucas.dataNasc = new DateTime (2010, 01, 19, 04,30,58);
      //  Lucas.Nome = "Lucas Schiaffino";

        //Console.WriteLine(Lucas.endereco.logradouro);
        //Console.WriteLine(Lucas.endereco.numero);
        //Console.WriteLine(Lucas.endereco.complemento);
        //Console.WriteLine(Lucas.endereco.enderecoComercial);
       // Console.WriteLine(Lucas.Nome);
        //Console.WriteLine(Lucas.cpf);
        //Console.WriteLine(Lucas.dataNasc);

// O ___ , cujo cpf é ___ e faz aniversario no dia ___ mora na ____ numero ____ 
        //concatenação
    //Console.WriteLine("O " + Lucas.Nome + ", cujo CPF é " + Lucas.cpf + " e nasceu no dia " + Lucas.dataNasc + " mora na " + Lucas.endereco.logradouro + " numero " + Lucas.endereco.numero );

//interpolação
    //Console.WriteLine($"O {Lucas.Nome}, cujo CPF é {Lucas.cpf} e faz aniversario no dia {Lucas.dataNasc} mora na {Lucas.endereco.logradouro} numero {Lucas.endereco.numero}"); 

            //Console.WriteLine(Lucas.ValidarDataNascimento(Lucas.dataNasc));
           // bool idadeValidada = Lucas.ValidarDataNascimento(Lucas.dataNasc);
          //  Console.WriteLine(idadeValidada);
        /*
            if (idadeValidada == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                Seu Cadastro Foi Aprovado                            *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.ResetColor();
            }
*/
        }
    }
}