namespace IEvangelist.CSharp.Eight
{
    class NullableReferenceTypes
    {
        #nullable disable // Toggle to enable

        class Person
        {
            internal string FirstName { get; set; }

            internal string MiddleName { get; set; } // Annotate as nullable

            internal string LastName { get; set; }

            internal Person(string first, string last) =>
                (FirstName, LastName) = (first, last);

            internal Person(string first, string middle, string last) =>
                (FirstName, MiddleName, LastName) = (first, middle, last);

            public override string ToString() => $"{FirstName} {MiddleName} {LastName}";
        }

        internal static string Exemplify()
        {
            var miguel = new Person("Miguel", "de Icaza");
            var length = GetLengthOfMiddleName(miguel);

            return $"{miguel.FirstName}'s middle name has {length} characters in it.";

            static int GetLengthOfMiddleName(Person person)
            {
                // Write defensively.
                string middleName = person.MiddleName;
                return middleName.Length;
            }
        }
    }
}