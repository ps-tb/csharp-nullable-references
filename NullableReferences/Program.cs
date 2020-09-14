using System;
using NullableLibrary;

namespace NullableReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = new Location("MD", null);
            var adoptionAgency = new AdoptionAgency("Bob's Cats", location);

            var cat = adoptionAgency.AdoptCat("Stevie", "Sammy");

            Console.WriteLine($"Cat's name: {cat.Name}");
            Console.WriteLine($"State of adoption agency: {cat.AdoptionAgency.Location.State}");
            Console.WriteLine($"Adoption agency street type: {cat.AdoptionAgency.Location.StreetAddress.StreetType}");
        }
    }
}