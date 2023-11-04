// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.Core.Models
{
    public class MeowMage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FlavorText { get; set; }

        public MeowMage(string name, string flavorText = "")
        {
            Id = Guid.NewGuid();
            Name = name;
            FlavorText = flavorText;
        }
    }
}