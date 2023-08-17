using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TorresVendas.UI
{
    public class ProdutoUI 
    {
        class Produto
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
        }

        public void Menu()
        {
            List<Produto> produtos = new List<Produto>();

            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Listar produtos");
                Console.WriteLine("2 - Cadastrar produto");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Lista de produtos:");
                        foreach (var produto in produtos)
                        {
                            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C2}");
                        }
                        break;
                    case "2":
                        Console.Write("Informe o nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o preço do produto: ");
                        double preco = double.Parse(Console.ReadLine());

                        produtos.Add(new Produto { Nome = nome, Preco = preco });
                        Console.WriteLine("Produto cadastrado!");
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
        }

        
    }
}