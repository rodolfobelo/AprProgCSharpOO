using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace ScreenSound_04.Modelos;

internal class Personagem
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("aliases")]
    public List<string>? Aliases { get; set; }
    public void ExibirApelidosDaPersonagem()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Apelidos:");
        foreach (var alias in Aliases)
        {
            Console.WriteLine($" - {alias}");
        }
    }
}
