using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresVendas.UI
{
    internal class CategoriaUI
    {

        class Categoria
        {
            public string Nome { get; set; }
            public string Desc { get; set; }
        }

        public void Menu()
        {
            List<Categoria> categorias = new List<Categoria>();

            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Listar categorias");
                Console.WriteLine("2 - Cadastrar categoria");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Lista de categorias:");
                        foreach (var categoria in categorias)
                        {
                            Console.WriteLine($"Nome: {categoria.Nome}, Descricao: {categoria.Desc}");
                        }
                        break;
                    case "2":
                        Console.Write("Informe o nome da Categoria: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe a descricao da Categoria: ");
                        string desc = Console.ReadLine();

                        categorias.Add(new Categoria { Nome = nome, Desc = desc });
                        Console.WriteLine("Categoria cadastrado!");
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

