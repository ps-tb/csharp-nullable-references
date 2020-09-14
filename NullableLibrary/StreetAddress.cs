namespace NullableLibrary
{
    public class StreetAddress
    {
        public int Number { get; }

        public string StreetName { get; }

        public string? StreetType { get; }

        public StreetAddress(int number, string streetName, string? streetType)
        {
            Number = number;
            StreetName = streetName;
            StreetType = streetType;
        }
    }
}