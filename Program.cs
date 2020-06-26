using System;
using System.Collections.Generic;

namespace VendaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            List<Produto> list = new List<Produto>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nProduto #{i + 1} ");

                Console.Write("\nProduto: ");
                string nome = Console.ReadLine();

                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Usado, Importado ou Comum  (u/i/c)");
                char escolha = char.Parse(Console.ReadLine());




                if (escolha == 'u' || escolha == 'U')
                {
                    Console.Write("Digite a data de fabricacao: ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, fabricacao));
                }

                else if (escolha == 'i' || escolha == 'I')
                {
                    Console.Write("Digite a taxa de alfandega: ");
                    double taxa = double.Parse(Console.ReadLine());
                    list.Add(new ProdutoImportado(nome, preco, taxa));
                }

                else if (escolha == 'c' || escolha == 'C')
                {
                    list.Add(new Produto(nome, preco));
                }

            }

            Console.WriteLine("");
            foreach (Produto prod in list)
            {
                Console.WriteLine(prod.Etiqueta());
            }
        }
    }
}
