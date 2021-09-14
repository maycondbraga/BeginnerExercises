using System.Globalization;

namespace Exercicios.Estrutura.Classes
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /// <summary> Retorna o total em estoque </summary>
        public double ValorTotalEmEstoque()
        {
            double total = Preco * Quantidade;
            return total;
        }

        ///<summary> Adiciona unidades a um produto determinado </summary>
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        ///<summary> Remove unidades a um produto determinado </summary>
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        /// <summary> Formata corretamente o objeto Produto </summary>
        public override string ToString()
        {
            string preco = Preco.ToString("F2", CultureInfo.InvariantCulture);
            string total = ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            return Nome + ", $ " + preco + ", " + Quantidade + " unidades, Total: $ " + total;
        }
    }
}