using System.Collections.Generic;

namespace Ej1
{
    public class Person
    {   
        public Person(){}
        public Person (string FName, string LName){
            this.FirstName = FName;
            this.LastName = LName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public string this[string index]{
            get{
                if (index == "FirstName")
                    return this.FirstName;

                if (index == "LastName")
                    return this.LastName;
                else
                    throw new System.Exception("This property does not exist");
            }

            set{
                if (index == "FirstName")
                    this.FirstName = value;

                else if (index == "LastName")
                    this.LastName = value;
                else
                    throw new System.Exception("This property does not exist");
            }
        }

        public override string ToString()
        {
            return $"FirstName: {this.FirstName}, LastName:{this.LastName}";
        }
    }
}