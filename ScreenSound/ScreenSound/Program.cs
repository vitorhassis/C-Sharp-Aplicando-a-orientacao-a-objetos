Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

//instanciando a classe musica 2 vezes (musica1 e musica2) sendo então, ambos, dois objetos da classe Musica
Musica musica1 = new Musica(queen, "Love of My Life")
{
    Duracao = 213, //inicializadores de propriedades
    Disponivel = true,
};



Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1); 
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();
