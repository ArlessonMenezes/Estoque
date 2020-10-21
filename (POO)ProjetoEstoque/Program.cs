using System;
using System.Globalization;
using System.Xml;

namespace _POO_ProjetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            inicio:
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdcionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            escolha:
            Console.Write("Deseja entrar com um novo produto? [s/n]: ");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S')
                goto inicio;
            else if (escolha == 'n' || escolha == 'N')
                Console.WriteLine("Fim do programa");
            else
            {
                Console.WriteLine("Opção inválida");
                goto escolha;
            }

        }
    }
}
