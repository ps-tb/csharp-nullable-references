namespace NullableLibrary
{
    public class AdoptionAgency
    {
        public string Name { get; }

        public Location Location { get; }

        public AdoptionAgency(string name, Location location)
        {
            Name = name;
            Location = location;
        }

        public Cat AdoptCat(string nameFromAgency, string? newName)
        {
            return new Cat(newName, CatType.Nice, this);
        }
    }
}