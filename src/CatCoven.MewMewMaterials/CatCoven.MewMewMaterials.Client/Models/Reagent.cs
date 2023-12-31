﻿// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.Client.Models
{
    public class Reagent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string FlavorText { get; set; }

        public Reagent(string name, int quantity = 1, string flavorText = "")
        {
            Id = Guid.NewGuid();
            Name = name;
            Quantity = quantity;
            FlavorText = flavorText;
        }
    }
}