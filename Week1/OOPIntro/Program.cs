using System;
using System.Collections.Generic;

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

            Student j = new Student("Jason", "Irvin");
            Console.WriteLine(j);

            Course cSharpDecember = new Course("C#", new DateTime(2020, 11, 20), new DateTime(2020, 12, 23));

            j.Courses.Add(cSharpDecember);
            Console.WriteLine($"J has {j.Courses.Count} courses.");

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
            return $"The person's name is {FullName} and has {HairColor} hair.";
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

    class Course
    {
        // properties that belong to the instances (objects)
        public string Stack {get;}

        public DateTime StartDate {get;}

        public DateTime EndDate {get;}

        public Course(string stack, DateTime startDate, DateTime endDate)
        {
            // def __init__(self, stack, start_date, end_date):
            //     self.stack = stack
            this.Stack = stack;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }

    // in Python
    // class Student(Person):
    // Inheritance (from the Person class)
    class Student : Person
    {
        public List<Course> Courses {get;set;}

        // super().__init__(first, last)
        // 
        public Student(string first, string last) : base(first, last)
        {
            Courses = new List<Course>();
        }
    }
}
