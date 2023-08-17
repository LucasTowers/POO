using TorresVendas.UI;

bool continuar = true;
do
{
    Console.Clear();
    Console.WriteLine("----------Sistema Gerenciador de Vendas TorresVendas----------");
    Console.WriteLine("1 - Gerenciar produtos");
    Console.WriteLine("2 - Gerenciar categorias");
    Console.WriteLine("3 - Gerenciar forncedores");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("--------------------------------------------------------------");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            ProdutoUI produtoUI = new();
            produtoUI.Menu();
            break;
        case "2":
            CategoriaUI categoriaUI = new();
            categoriaUI.Menu();
            break;
        case "3":
            FornecedorUI fornecedorUI = new();
            fornecedorUI.Menu();
            break;
        case "0":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
} while (continuar);