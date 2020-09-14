namespace NullableLibrary
{
    public class Location
    {
        public string State { get; }

        public StreetAddress? StreetAddress { get; }

        public Location(string state, StreetAddress? streetAddress)
        {
            State = state;
            StreetAddress = streetAddress;
        }
    }
}