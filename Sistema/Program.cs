namespace Sistema{
    class Program{
        static void Main(string[] args)
        {
            Console.Clear();

            void BarraCarregamento(string textoCarregamento, string icone){
                Console.WriteLine(textoCarregamento);
                Thread.Sleep(500);
                for (var contador = 0; contador < 3; contador++)
                {
                Console.Write(icone);
                Thread.Sleep(500);
                }

                Console.WriteLine("");

            }


            Console.ForegroundColor = ConsoleColor.Cyan;
           // Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"
===================================================================
|                                                                 |
|  Bem vindo ao sistema de cadastro de pessoa fisica e juridica   |
|                                                                 |
===================================================================");
BarraCarregamento("Iniciando","@");
BarraCarregamento("Procurando a solução do seu problema","@");

string oqueocaradigitounoteclado;

do{
     Console.WriteLine(@$"
==================================================================
|                   Escolha uma das opções abaixo                |
==================================================================
|                 1 - Pessoa Física                              |
|                 2 - Pessoa Juridica                            |
|                                                                |
|                 0 - Sair                                       |    
==================================================================");

    oqueocaradigitounoteclado = Console.ReadLine();

    switch (oqueocaradigitounoteclado)
    {
        case "1":
        Endereco banana = new Endereco();
        banana.logradouro = "Rua X";
        banana.numero = 100;
        banana.complemento = "Perto do senai";
        banana.enderecoComercial = false;

           PessoaFisica Lucas = new PessoaFisica();
            Lucas.endereco = banana;
            Lucas.cpf = "12345678";
            Lucas.dataNasc = new DateTime (2000, 01, 19, 04,30,58);
            Lucas.Nome = "Lucas Schiaffino";

        Console.WriteLine(Lucas.endereco.logradouro);
        Console.WriteLine(Lucas.endereco.numero);
        Console.WriteLine(Lucas.endereco.complemento);
        Console.WriteLine(Lucas.endereco.enderecoComercial);
        Console.WriteLine(Lucas.Nome);
        Console.WriteLine(Lucas.cpf);
        Console.WriteLine(Lucas.dataNasc);

        bool idadeValidada = Lucas.ValidarDataNascimento(Lucas.dataNasc);

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
                Console.ForegroundColor = ConsoleColor.Cyan;
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        break;
        case "2":
        Endereco endcom = new Endereco();

        Console.WriteLine("Digite seu Logradouro");
        endcom.logradouro = Console.ReadLine();

        endcom.numero = 100;
        endcom.complemento = "Perto do senai";
        endcom.enderecoComercial = true;

        PessoaJuridica LC = new PessoaJuridica();
        LC.endereco = endcom;
        LC.cnpj = "1235678990001";
        LC.razaoSocial = "Pessoa Juridica";

        
        Console.WriteLine(LC.endereco.numero);
        Console.WriteLine(LC.endereco.complemento);
        Console.WriteLine(LC.endereco.enderecoComercial);
        Console.WriteLine(LC.endereco.logradouro);
        Console.WriteLine(LC.Nome);
        Console.WriteLine(LC.cnpj);

        bool cnpjvalidado = LC.validarCNPJ(LC.cnpj);
       
       if(cnpjvalidado == true){
        Console.WriteLine("Verdadeiro - O CNPJ é valido");
       }else{
        Console.WriteLine("Falso - O CNPJ é invalido");
       }

        break;
        case "0":
        Console.WriteLine("Obrigado por utilizar o nosso sistema... até a proxima.");
        BarraCarregamento("Fechando o sistema", "@");
        Console.ResetColor();
        break;
        default:
        Console.WriteLine("Opção Invalida, digite uma das opções apresentadas acima.");
        break;
    }
}while(oqueocaradigitounoteclado != "0");      

        }
    }
}