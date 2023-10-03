Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{

    Duracao = 213
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354
};


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

musica1.ExibirFichaTecnica();