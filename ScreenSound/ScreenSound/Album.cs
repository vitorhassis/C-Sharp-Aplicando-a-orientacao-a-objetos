class Album
{
    public Album(string nome)
    {
        Nome = nome;   
    }

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; } //"A night at the opera". So o get, tem q inicializar no construtor
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    /*o metodo AdicionarMusica vai adicionar na lista musica, o parametro musica. No caso da sua estrutura, (Musica musica) Musica = pra onde vai; musica = o que vai ser levado
     */
    public void AdicionarMusica(Musica musica) 
    {
        musicas.Add(musica); //adicionar o parametro no array, ou seja, adicionar musica na lista de musicas. Dentro pra fora!
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Listas de musicas do ábum {Nome}:\n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este album inteiro voce precisa de {DuracaoTotal} segundos");
    }
}