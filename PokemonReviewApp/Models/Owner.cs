﻿using System;
namespace PokemonReviewApp.Models
{
	public class Owner
	{
        public int Id { get; set; }
        public string Gym { get; set; }
        public string Name { get; set; }
		public Country Country { get; set; }
		public ICollection<Owner> PokemonOwners { get; set; }

		public Owner()
		{
		}
	}
}

