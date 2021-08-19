using System.Globalization;

namespace MovimentacaoBasicaDeEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        

        //Construtor adicionado para exigir que os dados sejam informados
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Novo contrutor
        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //void porque não retorna nenhum valor
        public void AdicionarProdutos(int quantidade)
        {
            //Efetua o cálculo de Quantidade + quantidade;
            //Outra forma que poderia ser utilizada, seria:
            //Quantidade = Quantida + quantidade;
            Quantidade += quantidade;
        }


        public void RemoverProdutos(int quantidade)
        {            
            Quantidade -= quantidade;
        }


        //Definição de como um produto será transformado em forma de String
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
