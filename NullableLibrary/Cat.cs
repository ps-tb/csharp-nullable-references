namespace NullableLibrary
{
    public class Cat
    {
        public string? Name { get; }

        public CatType CatType { get; }

        public AdoptionAgency AdoptionAgency { get; }

        public Cat(string? name, CatType catType, AdoptionAgency adoptionAgency)
        {
            Name = name;
            CatType = catType;
            AdoptionAgency = adoptionAgency;
        }
    }

    public enum CatType
    {
        Nice,
        Mean
    }
}