using System.Collections.Generic;
using UnicornDB.Core.Models;

namespace UnicornDB.Core.Services
{
    public class UnicornRepository
    {
        public List<Unicorn> Unicorns { get; private set; }

        public UnicornRepository()
        {
            Unicorns = new List<Unicorn>();
            SeedUnicorns();
        }

        public void AddRandomUnicorn()
        {
            Unicorns.Add(GetRandomUnicorn());
        }

        public Unicorn GetRandomUnicorn()
        {
            return new Unicorn
            {
                Name = $"Unicorn{Unicorns.Count}",
                Color = "White",
                HairThickness = 1.5 + Unicorns.Count,
                HornSize = Unicorns.Count * 2
            };
        }

        private void SeedUnicorns()
        {
            var uni = new Unicorn
            {
                Name = "The Unicorn",
                Color = "White",
                HairThickness = 1.5,
                HornSize = 20
            };
            var uni2 = new Unicorn
            {
                Name = "Uni the second",
                Color = "Black",
                HairThickness = 3.0,
                HornSize = 30
            };
            var uni3 = new Unicorn
            {
                Name = "Little Pony",
                Color = "Purple",
                HairThickness = 1,
                HornSize = 10
            };
            var uni4 = new Unicorn
            {
                Name = "Uni the forth",
                Color = "Blue",
                HairThickness = 1.2,
                HornSize = 15
            };

            Unicorns.Add(uni);
            Unicorns.Add(uni2);
            Unicorns.Add(uni3);
            Unicorns.Add(uni4);
        }
    }
}
