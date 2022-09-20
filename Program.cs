using Classes;

bool rodando = true;

while (rodando = true){
    Console.WriteLine("1 - Inserir Dados de pessoa física");
    Console.WriteLine("2 - Inserir Dados de pessoa jurídica");
    Console.WriteLine("3 - Mostrar Dados");
    int menu;
    menu = Int32.Parse(Console.ReadLine());

    switch(menu)
    {
        case 1:
            pessoafisica pf = new pessoafisica();
            Console.WriteLine("Digite seu nome");
            pf.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            pf.idade = Int32.Parse(Console.ReadLine());
            bool vpf = true;
        break;

        case 2:
            pessoajuridica pj = new pessoajuridica();
            Console.WriteLine("Digite sua razão social");
            pj.rsocial = Console.ReadLine();
            Console.WriteLine("Digite seu CNPJ");
            pj.rsocial = Console.ReadLine();
            Console.WriteLine("Digite sua Inscrição Municipal");
            pj.inscricao = Console.ReadLine();
            bool vpj = true;

        break;

        case 3:
        


        break;

    }

}