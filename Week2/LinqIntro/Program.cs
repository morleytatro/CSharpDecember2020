using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
    class MainClass {
        public static void Main (string[] args) {
            int[] numbers = new int[]
            {
                5,
                10,
                25,
                2,
                60,
                32,
                22,
                98,
                50
            };

            // NUMBERS
            // Finding

            // using FirstOrDefault because 55 isn't in there
            // returns 0 as the default value
            var myNumber = numbers
                .FirstOrDefault(number => number == 55);

            // Console.WriteLine(myNumber);

            // Filtering
            // greater than 40
            var greaterThan40 = numbers
                // note that our lambda returns a boolean
                // means that the numbers that satisfy the condition
                // will be kept for the outcome
                .Where(number => number > 40)
                .ToArray();

            foreach(var val in greaterThan40)
            {
                // Console.WriteLine(val);
            }

            // Sorting
            var sortedNumbers = numbers
                .OrderBy(num => num)
                .ToArray();

            foreach(var num in sortedNumbers)
            {
                // Console.WriteLine(num);
            }

            var descendingOrder = numbers
                .OrderByDescending(num => num)
                .ToArray();

            foreach(var num in descendingOrder)
            {
                // Console.WriteLine(num);
            }
            
            // STUDENTS
            // Finding
            var student10 = Student.students
                .FirstOrDefault(student => student.Id == 50);

            // Find object by ID using the Django ORM
            // Student.objects.get(id=50)

            if(student10 == null)
            {
                Console.WriteLine("Student doesn't exist!");
            }

            // Filtering
            // Find the students whose favorite number is greater than 20
            var favNumberGreaterThan20 = Student.students
                .Where(student => student.FavoriteNumber > 20)
                .ToList();

            foreach(var student in favNumberGreaterThan20)
            {
                // Console.WriteLine(student);
            }

            // Sorting
            // Sort the students by favorite number (ascending)
            var sortedByFavoriteNumber = Student.students
                .OrderBy(student => student.FavoriteNumber)
                .ToList();

            foreach(var student in sortedByFavoriteNumber)
            {
                // Console.WriteLine(student);
            }

            // Filtering and Sorting
            // you'll want to filter first!
            // otherwise, you'll have to "look at" every element
            // for each operation
            var filteredAndSorted = Student.students
                .Where(student => student.FavoriteNumber > 30)
                .OrderBy(student => student.FavoriteNumber)
                .ToList();

            foreach(var student in filteredAndSorted)
            {
                Console.WriteLine(student);
            }
        }

        public class Student
        {
            public int Id {get;}
            public string FirstName {get;set;}
            public string LastName {get;set;}
            public string Email {get;set;}
            public int FavoriteNumber {get;set;}

            private static int nextId = 1;

            // constructor
            public Student(string first, string last, string email, int favNumber)
            {
                Id = nextId++; // increments the static field on instantiation
                FirstName = first;
                LastName = last;
                Email = email;
                FavoriteNumber = favNumber;
            }

            // gets us a nice string representation of a student
            public override string ToString()
            {
                return $"ID: {Id}; {FirstName} {LastName}; {Email}; {FavoriteNumber}";
            }

            // note that this is static, meaning it is connected with the class
            // not a specific object
            public static List<Student> students = new List<Student>
            {
                new Student("Adam", "Humecky", "a@h.com", 97),
                new Student("Brendan", "Walsh", "b@w.com", 10),
                new Student("Brian", "Seitz", "b@s.com", 29),
                new Student("Cayman", "Tomsic", "c@t.com", 49),
                new Student("Daniel", "Havens", "d@h.com", 7),
                new Student("David", "Kavanaugh", "d@k.com", 12),
                new Student("Donna", "Nolan", "d@n.com", 28),
                new Student("Eric", "Nuss", "e@n.com", 66),
                new Student("Gary", "Mckinnon", "g@m.com", 5),
                new Student("Harold \"Trey\"", "Danks", "h@d.com", 21),
                new Student("Jason", "Irvin", "j@i.com", 100),
                new Student("Joshua", "Moten", "j@m.com", 44),
                new Student("Joshua", "Park", "j@p.com", 93),
                new Student("Joshua", "Weber", "j@w.com", 90),
                new Student("Josiah", "Silva", "j@s.com", 78),
                new Student("Kyle", "Howell", "k@h.com", 27),
                new Student("Ling", "Xu", "l@x.com", 4),
                new Student("Mark", "Kleinsasser", "m@k.com", 11),
                new Student("Phillip \"Ian\"", "Rones", "p@r.com", 60),
                new Student("Quinton", "Edwards", "q@e.com", 96),
                new Student("Riley", "Burns", "r@b.com", 86),
                new Student("Sarah", "Chae", "s@c.com", 8),
                new Student("Sean", "Sarreal", "s@s.com", 59),
                new Student("Sharon", "Agcaoili", "s@a.com", 28),
                new Student("Stephen", "Lebel", "s@l.com", 100),
                new Student("Steven", "Halla", "s@h.com", 83),
                new Student("Steven", "Wittkopf", "s@w.com", 53),
                new Student("Thitipong \"Paul\"", "Readshaw", "t@r.com", 44),
                new Student("Tim", "Schumann", "t@s.com", 25),
                new Student("Zach", "Cortez", "z@c.com", 56)
            };
        }
    }
}
