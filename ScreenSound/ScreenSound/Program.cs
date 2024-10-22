    Album albumDoQueen = new Album(); //instanciando a classe 
    albumDoQueen.Nome = "A night at the opera";

    Musica musica1 = new Musica();
    musica1.Nome = "Love of My Life";
musica1.Duracao = 213; 

    Musica musica2 = new Musica();
    musica2.Nome = "Bohemian Rhapsody";
    musica2.Duracao = 354;

/*musica1 e musica2 sao propriedades que serao passadas como parametro para a funcao AdicionarMusica que, por sua vez tem a ação de adicionar o que 
 for de parametro no array. Ou seja, chamamos uma função que vai adicionar a música na lista de musicas, através da função*/
    albumDoQueen.AdicionarMusica(musica1); 
    albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();
