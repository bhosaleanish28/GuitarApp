using System.Collections.Generic;

namespace GuitarApp.Model
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, type, backWood, topWood);
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (var guitar in guitars)
            {
                if (guitar.Spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }
    }
}
