using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroDeProdutos.Controllers
{
    class ItemFuncoes
    {
        private List<Item> listaItens = new List<Item>();
        private int proximoId = 1;

        public void AdicionarItem()
        {
            Console.Write("Nome do Item: ");
            string nome = Console.ReadLine();

            Item novoItem = new Item
            {
                Id = proximoId++,
                Nome = nome
            };

            listaItens.Add(novoItem);
            Console.WriteLine("Item adicionado com sucesso!");
        }

        public void ListarItens()
        {
            Console.WriteLine("Lista de Itens:");
            foreach (var item in listaItens)
            {
                Console.WriteLine($"ID: {item.Id}, Nome: {item.Nome}");
            }
        }

        public void ExcluirItem()
        {
            Console.Write("Informe o ID do item que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());

            Item itemExistente = listaItens.FirstOrDefault(x => x.Id == id);

            if (itemExistente != null)
            {
                listaItens.Remove(itemExistente);
                Console.WriteLine("Item excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Item não encontrado.");
            }
        }
    }
}
