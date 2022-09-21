using Classes;

bool rodando = true;
pessoafisica pf = new pessoafisica();
pessoajuridica pj = new pessoajuridica();
bool vpf = false;
bool vpj = false;

while (rodando = true){
    Console.WriteLine("1 - Inserir Dados de pessoa física");
    Console.WriteLine("2 - Inserir Dados de pessoa jurídica");
    Console.WriteLine("3 - Mostrar Dados");
    int menu;
    menu = Int32.Parse(Console.ReadLine());


    switch(menu)
    {
        case 1:           
            Console.WriteLine("Digite seu nome");
            pf.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            pf.idade = Int32.Parse(Console.ReadLine());
            vpf = true; // Verififica se o usuário inseriu informações de PF para futura exibição
        break;

        case 2:
            Console.WriteLine("Digite sua razão social");
            pj.rsocial = Console.ReadLine();
            Console.WriteLine("Digite seu CNPJ");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("Digite sua Inscrição Municipal");
            pj.inscricao = Console.ReadLine();
            vpj = true;

        break;

        case 3:
            if (vpf == true){
                Console.WriteLine("****PESSOA FÍSICA DETECADA****");
                Console.WriteLine("Nome: " + pf.nome);
                Console.WriteLine("CPF: " + pf.cpf);
                Console.WriteLine("Idade: " + pf.idade);

            }else{
                
                Console.WriteLine("****PESSOA FÍSICA NAO DETECADA****");
            }

            if (vpj == true){

                Console.WriteLine("****PESSOA JURÍDICA DETECADA****");
                Console.WriteLine("Razão Social: " + pj.rsocial);
                Console.WriteLine("CNPJ : " + pj.cnpj);
                Console.WriteLine("Razão Social: " + pj.inscricao);

            }else{
                Console.WriteLine("****PESSOA JURÍDICA NAO DETECADA****");
            }


        break;


        default:
        Console.WriteLine("Selecione uma opção válida.");
        break;

    }

}