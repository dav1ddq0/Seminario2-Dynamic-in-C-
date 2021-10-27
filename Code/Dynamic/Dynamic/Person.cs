namespace Dynamic
{
    public class Person
    {

        public string firstName{get;set;}
        public string lastName{get;set;}

        #region  Method Chaining
        public Person FirstName(string firstName){
            this.firstName = firstName;
            return this;
        }

        public Person LastName(string lastName){
            this.lastName = lastName;
            return this;
        }
        #endregion
        
    }
}