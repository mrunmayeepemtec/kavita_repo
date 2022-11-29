﻿namespace CrudWebApiEF.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        // One to many realtionship
        public ICollection<Review> Reviews { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }  
        
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
