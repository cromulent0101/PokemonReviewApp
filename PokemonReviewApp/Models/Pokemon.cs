using System;
namespace PokemonReviewApp.Models
{
	public class Pokemon
    {
		public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
		public ICollection<Review> Reviews { get; set; }


		public Pokemon()
		{
		}
	}
}

