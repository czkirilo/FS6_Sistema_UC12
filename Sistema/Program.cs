namespace Sistema{
    class Program{
        static void Main(string[] args)
        {
           // Pessoa Isadora = new Pessoa();
             PessoaFisica Isadora = new PessoaFisica();

             PessoaJuridica Jequiti = new PessoaJuridica();

             Jequiti.cnpj = "654168484";
             Jequiti.Nome = "Jequiti do silvio";

            Isadora.cpf = "6559514";
            Isadora.Nome = "Isadora Onorato";
            Isadora.Endereco = "Rua x, Nº 48";
            Isadora.enderecoComercial = true;
            
            Console.WriteLine(Jequiti.cnpj);
            Console.WriteLine(Jequiti.Nome);
            Console.WriteLine(Isadora.Nome);
            Console.WriteLine(Isadora.Endereco);
            Console.WriteLine(Isadora.enderecoComercial);
            Console.WriteLine(Isadora.cpf);

            
        }
    }
}