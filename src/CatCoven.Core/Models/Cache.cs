// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.Core.Models
{
    public class Cache
    {
        public Guid Id { get; set; }
        public MeowMage MeowMage { get; set; }
        public List<Reagent> Reagents { get; set; }

        public Cache (MeowMage meowMage)
        {
            Id = Guid.NewGuid();
            MeowMage = meowMage;
            Reagents = new List<Reagent>();
        }
    }
}
