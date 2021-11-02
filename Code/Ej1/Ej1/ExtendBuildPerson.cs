using System.Collections.Generic;

namespace Ej1
{
    public static class ExtendBuildPerson
    {
        public static Person Person(this BuildPerson buildP, string FirstName, string LastName) {
            return new Person(FirstName, LastName);
        }
    }

    public static class ExtendBuildPerson2 {
        public static Person Person(this BuildPerson buildP, Dictionary<string, string> props) {
            return new Person(props["FirstName"], props["LastName"]);
        }
    }
}