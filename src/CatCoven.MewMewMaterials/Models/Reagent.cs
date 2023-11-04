// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.Models
{
    public class Reagent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Reagent(string name, int quantity = 1)
        {
            Id = Guid.NewGuid();
            Name = name;
            Quantity = quantity;
        }
    }
}