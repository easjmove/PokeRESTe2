namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; } // ikke null
        public string? Name { get; set; } // ikke null, minimum længde 2
        public int Level { get; set; } // 1-99
        public int PokeDex { get; set; } // positivt > 0
    }
}
