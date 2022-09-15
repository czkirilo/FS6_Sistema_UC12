namespace Sistema{
    class Program{
        static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();
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
|                     Pessoa Física                              |
|                 1 - Cadastrar Pessoa Fisica                    |
|                 2 - Listar Pessoa Fisica                       |
|                 3 - Remover Pessoa Fisica                      |
|                                                                |
|                     Pessoa Juridica                            |
|                 4 - Cadastrar Pessoa Juridica                  |
|                 5 - Listar Pessoa Juridica                     |
|                 6 - Remover Pessoa Juridica                    |
|                                                                |
|                 0 - Sair                                       |    
==================================================================");

    oqueocaradigitounoteclado = Console.ReadLine();

    switch (oqueocaradigitounoteclado)
    {
        case "1":
       /*
        Endereco banana = new Endereco();
        Console.WriteLine($"Digite seu logradouro");
        banana.logradouro = Console.ReadLine();

        Console.WriteLine("Digite o numero da sua residencia");
        banana.numero = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o complemento (Aperte enter para vazio)");
        banana.complemento = Console.ReadLine();

        Console.WriteLine("Este endereço é comercial? S/N");
        string oqueeledigitou = Console.ReadLine().ToUpper();
        
        // == é igual
        if (oqueeledigitou == "S"){
            banana.enderecoComercial = true;
        } else{
            banana.enderecoComercial = false;
        }
*/
        //banana.logradouro = "Rua X";
        //banana.numero = 100;
        //banana.complemento = "Perto do senai";
        //banana.enderecoComercial = false;

           PessoaFisica novapf = new PessoaFisica();
         //  novapf.endereco = banana;
                        Console.WriteLine($"Digite seu CPF (somente números");
                        novapf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite seu nome");
                        novapf.Nome = Console.ReadLine();
                        
                     //   Console.WriteLine($"Digite o valor do seu rendimento mensal");
                      //  novapf.rendimento = float.Parse(Console.ReadLine());
                        
                      //  Console.WriteLine($"Digite sua data de nascimento");
                      //  novapf.dataNasc = DateTime.Parse(Console.ReadLine());

        bool idadeValidada = novapf.ValidarDataNascimento(novapf.dataNasc);

            if (idadeValidada == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*                Seu Cadastro Foi Aprovado                            *");
                listaPf.Add(novapf);
                Console.ForegroundColor = ConsoleColor.Cyan;
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            StreamWriter sw = new StreamWriter($"{novapf.Nome}.txt");
            sw.WriteLine(novapf.Nome);
            sw.WriteLine(novapf.cpf);


        break;
        case "2":
        //Listar pessoa fisica
        foreach (var cadaItem in listaPf){
            Console.WriteLine($"{cadaItem.cpf}, {cadaItem.Nome}");
        }

        break;
        case "3":// PARAMOS AQUI!!!!!!!!!!!!!!!!!!!!
        //Remover pessoa fisica
        Console.WriteLine("Digite o CPF que deseja remover [somente numeros]");
        string cpfProcurado = Console.ReadLine();

       PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

       if (pessoaEncontrada != null){
        listaPf.Remove(pessoaEncontrada);
        Console.WriteLine("Cadastro removido");
       }else{
            Console.WriteLine("CPF não encontrado");
       }
        break;
        case "4":
        //Cadastrar pessoa juridica
        break;
        case "5":
        //Listar pessoa juridica
        break;
        case "6":
        //Remover pessoa juridica
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

/*
 
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
        double ImpostoPago2 = LC.PagarImposto(10000);
        Console.WriteLine($"Ele vai pagar {ImpostoPago2} reais de imposto");

        
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

*/