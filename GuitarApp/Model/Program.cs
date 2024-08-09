using System;
using System.Collections.Generic;

namespace GuitarApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);

            List<Guitar> guitars = inventory.Search(whatErinLikes);
            if (guitars.Count > 0)
            {
                foreach (var guitar in guitars)
                {
                    Console.WriteLine("Erin, you might like this " +
                        $"{guitar.Spec.Builder} {guitar.Spec.Model} {guitar.Spec.Type} guitar:\n   " +
                        $"{guitar.Spec.BackWood} back and sides,\n   {guitar.Spec.TopWood} top.\nYou can have it for only ${guitar.Price}!");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95, Builder.Collings, "CJ", Type.Acoustic, Wood.IndianRosewood, Wood.Sitka);
            inventory.AddGuitar("V95693", 1499.95, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);
            inventory.AddGuitar("V9512", 1549.95, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);
            inventory.AddGuitar("122784", 5495.95, Builder.Martin, "D-18", Type.Acoustic, Wood.Mahogany, Wood.Adirondack);
            inventory.AddGuitar("76531", 6295.95, Builder.Martin, "OM-28", Type.Acoustic, Wood.BrazilianRosewood, Wood.Adirondack);
            inventory.AddGuitar("70108276", 2295.95, Builder.Gibson, "Les Paul", Type.Electric, Wood.Mahogany, Wood.Maple);
            inventory.AddGuitar("82765501", 1890.95, Builder.Gibson, "SG '61 Reissue", Type.Electric, Wood.Mahogany, Wood.Mahogany);
            inventory.AddGuitar("77023", 6275.95, Builder.PRS, "Dave Navarro Signature", Type.Electric, Wood.Mahogany, Wood.Maple);
        }
    }
}
