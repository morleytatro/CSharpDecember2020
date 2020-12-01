using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Person morley = new Person("Morley", "Tatro");

            // invoking our "setter" method
            morley.HairColor = "gray";
            // Console.WriteLine(morley);

            // this calls the get accessor for us
            Console.WriteLine(morley.FullName);

            Console.WriteLine(morley.HairColor);

            Person j = new Person("Jason", "Irvin");
            Console.WriteLine(j);

            // this causes an issue because the implicit access level is private
            // morley.firstName = "Morley";
        }
    }

    // Classes allow us to model our data.
    // Classes act as blueprints to create objects.
    class Person
    {
        // attributes are things that objects can have
        // methods are things that objects an do

        // these are fields, which typically have camel casing
        // string firstName;
        // string lastName;

        // string hairColor;

        // these are properties (notice the PascalCasing)
        public string FirstName {get;set;}
        public string LastName {get;set;}

        // effectively read only because we can only "get" it
        // it is derived
        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string HairColor {get;set;}

        // this is our constructor
        public Person(string first, string last, string hair = "black")
        {
            FirstName = first;
            LastName = last;
            HairColor = hair;
        }

        // def __str__(self)
        // overriding the built-in method to get a string representation
        public override string ToString()
        {
            return $"The person's name is {FirstName} {LastName} and has {HairColor} hair.";
        }

        // this is a setter method (allows us to access private fields)
        // public void SetHairColor(string newColor)
        // {
        //     hairColor = newColor;
        // }

        // this is a getter method (allows us to access private fields)
        // public string GetHairColor()
        // {
        //     return hairColor;
        // }
    }
}
