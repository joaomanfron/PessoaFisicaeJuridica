using Backend;
using Classes;

{
    
}

List<PessoaFisica> listaPf = new List<PessoaFisica>();

Console.Clear();
string? opcao;

Utils.BarraCarregamento("Carregando");
do {
Console.WriteLine(@$"
    =================================================
    |      Bem vindo ao Sistema de Cadastro De      |
    |           Pessoa Fisica Juridica              |
    =================================================
    |           1 - Pessoa Física                   |
    |                                               |
    |           2 - Pessoa Jurídica                 |
    |                                               |
    |           0 - Sair                            |
    =================================================
");
 Console.WriteLine("INFORME A OPÇÃO: ");
opcao = Console.ReadLine();
PessoaFisica metodosPf = new PessoaFisica();

switch (opcao) {
    case "1":
        

            string? opcaoPf;
        do {
            Console.Clear();
            Console.WriteLine(@$"
    =================================================
    |      Bem vindo ao Sistema de Cadastro De      |
    |           Pessoa Fisica Juridica              |
    =================================================
    |         1 - Cadastrar Pessoa Física           |
    |                                               |
    |         2 - Lista Pessoa Física               |
    |                                               |
    |       0 - Voltar ao menu anterior             |
    =================================================
    ");

        opcaoPf = Console.ReadLine();
        Thread.Sleep(2000);

        switch (opcaoPf) {
            case "1":
            Console.Clear();
                PessoaFisica novapf = new PessoaFisica ();
                EnderecoFinal novoEndPf = new EnderecoFinal();


                Console.WriteLine("Digite o nome da pessoa física: ");
                novapf.nome = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter($"{novapf.nome}.txt")) {
                sw.WriteLine(novapf.nome);
            }


            Console.Clear();
            Console.WriteLine($"Cadastro Gravado");
            Thread.Sleep(3000);
            break; 

            case "2": 
                Console.Clear();
                using (StreamReader sr = new StreamReader("João.txt")) {
                    string linha; 

                    while ((linha = sr.ReadLine()) != null){
                        Console.WriteLine(linha);
                    }
                    System.Console.WriteLine($"Tecle Enter");
                    Console.ReadLine();
                }


            break;

            case "0": 
                Utils.BarraCarregamento("Encerrando");
                Console.WriteLine("PROGRAMA ENCERRADO");
            break;

            default:
                Console.Clear();
                Console.WriteLine("COMANDO NÃO RECONHECIDO ----------> DIGITE UM COMANDO DO MENU");
                break;
            
        }

        } while (opcaoPf != "0");

        Console.WriteLine("PESSOA FÍSICA");


    break;

    case "2":
        Console.Clear();
        Console.WriteLine("PESSOA JURÍDICA");
        PessoaJuridica novapj = new PessoaJuridica ();
        PessoaJuridica metodosPj = new PessoaJuridica();
        EnderecoFinal novoEndPj = new EnderecoFinal();

        novapj.nome = "Tudo Nosso";
        novapj.razaoSocial = "Social";
        novapj.cnpj = "02.464.694/0001-43";
        novoEndPj.logradouro = "Rua Das Flores";
        novoEndPj.numero = 459;

        novapj.endereco = novoEndPj;
        
        metodosPj.Inserir(novapj);


        List<PessoaJuridica> listaExibicaoPj = metodosPj.LerArquivo();

        foreach (PessoaJuridica cadaItem in listaExibicaoPj)
        {
            Console.Clear();
            Console.WriteLine(@$"
            Nome: {cadaItem.nome}
            Razão Social: {cadaItem.razaoSocial}

            
            ");
            Console.WriteLine($"Presione Enter");
            Console.ReadLine();
        }

    break;
    case "0":
    Utils.BarraCarregamento("Encerrando");
    Console.WriteLine("PROGRAMA ENCERRADO");
    break;

    default:
    Console.Clear();
    Console.WriteLine("COMANDO NÃO RECONHECIDO ----------> DIGITE UM COMANDO DO MENU");
    break;
}
} while (opcao != "0");     

