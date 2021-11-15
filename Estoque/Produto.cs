using System.Globalization;

namespace Estoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){

            Quantidade += quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {

            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return ($"{Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total {ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
            
        }

    }
}