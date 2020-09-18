using System.Collections.Generic;

namespace NullableLibrary
{
    public class AdoptionAgency
    {
        public string Name { get; }

        public Location Location { get; }

        public IEnumerable<Cat> Cats { get; }

        public AdoptionAgency(string name, Location location)
        {
            Name = name;
            Location = location;
            Cats = new List<Cat>();
        }

        public Cat AdoptCat(string nameFromAgency, string? newName)
        {
            return new Cat(newName, CatType.Nice, this);
        }

        /// <summary>
        /// Method is no longer needed with non-null references
        /// </summary>
        /// <param name="name"></param>
        /// <param name="catFromAgency"></param>
        /// <returns></returns>
        public bool TryGetCat(string name, out Cat catFromAgency)
        {
            // this is for demo only
            catFromAgency = new Cat();
            return true;
        }

        /// <summary>
        /// TryGet replacement with null reference
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Cat? GetCatFromAgency(string name)
        {
            // didn't find Cat in list
            return null;
        }
    }
}