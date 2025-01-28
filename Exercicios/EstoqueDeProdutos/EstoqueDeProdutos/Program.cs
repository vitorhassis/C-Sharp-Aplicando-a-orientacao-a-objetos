

using System.Drawing;

class Estoque
{
    private List<Produto> produtos = new List<Produto>();
    public Produto Produtos { get; set; }
    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    } 

    public void ExibirTodosOsProdutos()
    {
        Console.WriteLine("Produtos em estoque: ");
        foreach(var produto in produtos)
        {
            Console.WriteLine($"Nome:{produto.Nome}\nQuantidade{produto.Quantidade}\nValor{produto.Valor}");
        }
    }
}


class Produto
{
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public string Nome { get; set; }

    //o construtor tem que estar dentro da classe
    public Produto(string nome, int quantidade, decimal valor)
    {
        Nome = nome;
        Quantidade = quantidade;
        Valor = valor;
    }
}








