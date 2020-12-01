using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            string[] myArray = new string[4]
            {
                "this",
                "that",
                "the other",
                "finally"
            };

            // myArray[0] = "this";

            // for(int i = 0; i < myArray.Length; i++)
            // {
            //     Console.WriteLine(myArray[i]);
            // }

            // alternative way of loop through array
            // foreach(var word in myArray)
            // {
            //     Console.WriteLine(word);
            // }

            object[] myObjectsArray = 
            {
                "this",
                "that",
                1,
                true
            };

            // foreach(object element in myObjectsArray)
            // {
            //     if(element is string)
            //     {
            //         Console.WriteLine(element);
            //     }
            // }

            List<string> names = new List<string>() {
                "Steven",
                "Jason",
                "Steven"
            };

            names.Add("Quinton");

            names.Remove("Steven");

            names.RemoveAt(1);

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Dictionary<string, object> myBook = new Dictionary<string, object>();

            myBook.Add("Title", "Infinite Jest");
            myBook.Add("Author", "David Foster Wallace");
            myBook.Add("Pages", 1079);
            myBook.Add("Genre", "surrealist satire");
            myBook.Add("Rating", 5);

            // my_book = {
            //     "title": "Infinite Jest",
            //     "author": "David Foster Wallace"
            // }
            myBook["Rating"] = 4;

            Dictionary<string, object> book2 = myBook;
            book2["Pages"] = 1000;

            Console.WriteLine(myBook["Pages"]);
        }
    }
}
