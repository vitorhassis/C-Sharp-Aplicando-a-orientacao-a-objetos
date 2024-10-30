class Musica
{
    //construtor
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get;  set; } 
    public Genero Genero { get; set; } //dentro da classe musica temos um objeto da classe Genero. A classe Musica possui tanto acesso de leitura quanto de gravação da instancia da classe Genero
    public string DescricaoResumida =>
        $"A musica {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
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
 