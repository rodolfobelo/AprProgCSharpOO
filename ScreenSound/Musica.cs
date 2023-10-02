﻿class Musica
{
    public Musica(Banda artista)
    {
        Artista = artista;
    }
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";
    public Genero Gerero { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Disponível no plano");
        }
        else { Console.WriteLine("Adquira o plano Plus+"); }
    }
    public int Somar(int a, int b) => a + b;
}