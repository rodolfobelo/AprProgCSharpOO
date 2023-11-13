using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filters;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        foreach(var artist in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicaPorArtista = musicas.Where(musica => musica.Artista!.Contains(artista)).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Musicas do artista/banda {musicas}:");
        foreach(var musica in musicaPorArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    public static void FiltrarTodasAsBandas(List<Musica> musicas)
    {
        var todasAsBandas = musicas.OrderBy(bandas => bandas.Artista).Select(bandas => bandas.Artista).Distinct().ToList();
        foreach( var banda in todasAsBandas)
        {
            Console.WriteLine($"- {banda}");
        }
    }
}
