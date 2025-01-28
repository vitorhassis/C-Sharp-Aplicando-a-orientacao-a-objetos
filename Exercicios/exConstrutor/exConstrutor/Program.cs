class Titular
{
    public Titular (string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }

}

class Conta
{
    public Conta (Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
    }

    //tem uma classe dentro de conta, e vc tbm coloca ele dentro do parametro do construtor. Fazendo com que, ele precise informar o titular antes da conta.
    public Titular Titular { get; set; }
    public int Agencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double Limite { get; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}

class Jogo
{
    public Jogo (int quantidade, int preco, string nome)
    {
        Quantidade = quantidade;
        Preco = preco;
        Nome = nome;
    }
    public int Quantidade { get; }
    public int Preco { get; }
    public string Nome { get; }
}

class Catalogo
{
    private List<Jogo> jogos = new List<Jogo>();
    public Catalogo (int quantidade, string nome)
    {
        Quantidade = quantidade;
        Nome = nome;
    }
    public int Quantidade { get; }
    public string Nome { get; }
    public void AdicionarJogo(Jogo jogo)
    {
        jogos.Add(jogo);
    }

    public void ExibirCatalogo()
    {
        Console.WriteLine($"Catalogo:{this.Nome}");
        Console.WriteLine($"Quantidade:{this.Quantidade}");

        foreach (Jogo jogo in jogos)
        {
            Console.WriteLine($"Nome {jogo.Nome}");
            Console.WriteLine($"Preco {jogo.Preco}");
            Console.WriteLine($"Quantidade {jogo.Quantidade}");
        }
    }
}





