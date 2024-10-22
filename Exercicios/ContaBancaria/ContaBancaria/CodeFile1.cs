class Conta
{
    public string usuario;
    public string senha;
    public int saldo;

    public void ExibirDados()
    {
        Console.WriteLine($"USUARIO {usuario}");
        Console.WriteLine($"SENHA {senha}");
        Console.WriteLine($"SALDO {saldo}");
    }

}