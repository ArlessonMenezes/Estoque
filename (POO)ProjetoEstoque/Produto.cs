using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _POO_ProjetoEstoque
{
    class Produto
    {
        //Atributos da classe Produto
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() //Informar valor total do estoque
        {
            return Preco * Quantidade;
        }


        public void AdcionarProduto(int quantidade) //Adcionando valores ao atributo Quantidade
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int remover) //Remover valores do atributo Quantidade
        {
            Quantidade -= remover;
        }


        public override string ToString() //Concatenando dados do produto informado
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
