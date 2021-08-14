using System.Globalization;

namespace MovimentacaoBasicaDeEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Definição de como um produto será transformado em forma de String
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
