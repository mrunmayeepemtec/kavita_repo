namespace CrudWebApiEF.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }

        public int CategoryId { get; set; }

        // Many to many Relationships
        public Pokemon Pokemon { get; set; }

        // Many to many Relationships
        public Category Category { get; set; }
    }
}
