﻿Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
  Duracao = 213,
  Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
  Duracao = 213,
  Disponivel = true,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();