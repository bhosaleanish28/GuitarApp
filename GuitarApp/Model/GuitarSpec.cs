namespace GuitarApp.Model
{
    public enum Builder
    {
        Any,
        Fender,
        Martin,
        Gibson,
        Collings,
        Olson,
        Ryan,
        PRS
    }

    public enum Type
    {
        Any,
        Acoustic,
        Electric
    }

    public enum Wood
    {
        Any,
        IndianRosewood,
        BrazilianRosewood,
        Mahogany,
        Maple,
        Cocobolo,
        Cedar,
        Adirondack,
        Alder,
        Sitka
    }
    public class GuitarSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Type Type { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder) return false;
            if (!string.IsNullOrEmpty(Model) && !Model.Equals(otherSpec.Model)) return false;
            if (Type != otherSpec.Type) return false;
            if (BackWood != otherSpec.BackWood) return false;
            if (TopWood != otherSpec.TopWood) return false;
            return true;
        }
    }
}
