namespace CrudWebApiEF.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }

        public int OwnerId { get; set; }

        // Many to many Relationships
        public Pokemon Pokemon { get; set; }

        // Many to many Relationships
        public Owner Owner { get; set; }
    }
}
