class Conta
{
    public string agencia { get; set; }
    public string numeroDaConta { get; set; }
    public int saldo { get; set; }
    public int limite { get; set; }
    public Titular Titular { get; set; } //a classe conta possui um objeto da classe Titular.

    public void InformacoesConta()
    {
        Console.WriteLine($"INFORMAÇÕES TITULAR: \n{this.Titular.nome}\nCpf: {this.Titular.cpf}\nData de nascimento: {this.Titular.dataNascimento}\nCelular {this.Titular.telefone}");
    }

}