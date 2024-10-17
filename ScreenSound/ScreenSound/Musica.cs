class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get;  set; } //operacao de leitura e escrita 
    public string DescricaoResumida =>
        $"A musica {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        Console.WriteLine($"Disponivel: {Disponivel}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        } else
        {
            Console.WriteLine("Adquita o plano Plus+");
        }
    }
}
 