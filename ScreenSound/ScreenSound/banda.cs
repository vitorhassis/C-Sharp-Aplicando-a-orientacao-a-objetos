class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albums = new List<Album>(); //array que vai armazenar os albuns da banda
    public string Nome { get; }//so o get = precisa necessariamente inicializar no construtor
    public void AdicionarAlbum(Album album) //método que armazena o parametro no argumento, no caso, na lista Album
    {
        albums.Add(album);
    }

    public void ExibirDiscografia() //outro método que concatena as informações em texto, para a exibição
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.Write($"Album {album.Nome} ({album.DuracaoTotal})");
        }
    }
}