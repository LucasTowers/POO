using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresVendas.UI
{
    public class FornecedorUI
    {

        class Fornecedor
        {
            public string Nome { get; set; }
            public double CNPJ { get; set; }
        }

        public void Menu()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Listar fornecedores");
                Console.WriteLine("2 - Cadastrar fornecedor");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Lista de fornecedores:");
                        foreach (var fornecedor in fornecedores)
                        {
                            Console.WriteLine($"Nome: {fornecedor.Nome}, CNPJ: {fornecedor.CNPJ}");
                        }
                        break;
                    case "2":
                        Console.Write("Informe o nome do fornecedor: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o CNPJ do fornecedor: ");
                        double cnpj = double.Parse(Console.ReadLine());

                        fornecedores.Add(new Fornecedor { Nome = nome, CNPJ = cnpj });
                        Console.WriteLine("Fornecedor cadastrado!");
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

