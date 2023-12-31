﻿// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.Service.Models
{
    public class Cache
    {
        public Guid Id { get; set; }
        public MeowMage MeowMage { get; set; }
        public List<Reagent> Reagents { get; set; }

        public Cache(MeowMage meowMage)
        {
            Id = Guid.NewGuid();
            MeowMage = meowMage;
            Reagents = new List<Reagent>();
        }

        public Reagent AddReagent(Reagent reagent)
        {
            foreach (var existingReagent in Reagents)
            {
                if (reagent.Name == existingReagent.Name)
                {
                    existingReagent.Quantity += reagent.Quantity;
                    return existingReagent;
                }
            }

            Reagents.Add(reagent);

            return reagent;
        }
    }
}