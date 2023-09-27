using cadastroDeProdutos.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

<<<<<<< HEAD
namespace cadastroDeProdutos
=======
namespace ConsoleCRUDWithClasses
>>>>>>> cfe1b91 (Adicionar arquivos de projeto.)
{
    class Program
    {
        public static void Main(string[] args)
        {
            ItemFuncoes itemFuncoes = new ItemFuncoes();

            while (true)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Adicionar Item");
                Console.WriteLine("2 - Listar Itens");
                Console.WriteLine("3 - Excluir Item");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        itemFuncoes.AdicionarItem();
                        break;

                    case "2":
                        itemFuncoes.ListarItens();
                        break;

                    case "3":
                        itemFuncoes.ExcluirItem();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}

