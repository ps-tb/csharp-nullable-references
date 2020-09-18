namespace NullableLibrary
{
    public class Cat
    {
        public string? Name { get; }

        public CatType CatType { get; }

        public AdoptionAgency AdoptionAgency { get; }

        /// <summary>
        /// This leaves values uninitialized
        /// </summary>
        public Cat()
        {
        }

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