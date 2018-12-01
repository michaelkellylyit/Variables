using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {

        enum Orientation : int
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person {
                FirstName = "Michael",
                SurName = "Kelly",
                HouseNo =4,
                Street = "deadstreet",
                Town ="notown",
                County = "orange" });
            people.Add(new Person {
                FirstName = "Hugh",
                SurName = "Deeney",
                HouseNo = 5,
                Street = "alivestreet",
                Town = "notown",
                County = "orange" });

            
            List<Person> secondList = new List<Person>();
            secondList.Add(new Person
            { FirstName = "Hugh",
              SurName = "Deeney",
              HouseNo = 5,
              Street = "alivestreet",
              Town = "notown",
              County ="orange"

            });

            people.AddRange(secondList);

            //people.Remove(new Person
            //{
            //    FirstName = "Hugh",
            //    SurName = "Deeney",
            //    HouseNo = 5,
            //    Street = "alivestreet",
            //    Town = "notown",
            //    County = "orange"

            //});

            Console.WriteLine(people.Contains(new Person
            {
                FirstName = "Hugh",
                SurName = "Deeney",
                HouseNo = 5,
                Street = "alivestreet",
                Town = "notown",
                County = "orange"

            }));

            people.RemoveAll(f => f.SurName =="Kelly");

            Console.WriteLine("Original order :");

            foreach (var Person in people)
            {
                Console.WriteLine($"FirstName = {Person.FirstName}");
                Console.WriteLine($"SurName = {Person.SurName}");
                Console.WriteLine($"HouseNo = {Person.HouseNo}");
                Console.WriteLine($"Street = {Person.Street}");
                Console.WriteLine($"Town = {Person.Town}");
                Console.WriteLine($"County = {Person.County}");
            }

            people.Reverse();

            Console.WriteLine("Reserve order :");
            foreach (var Person in people)
            {
                Console.WriteLine($"FirstName = {Person.FirstName}");
                Console.WriteLine($"SurName = {Person.SurName}");
                Console.WriteLine($"HouseNo = {Person.HouseNo}");
                Console.WriteLine($"Street = {Person.Street}");
                Console.WriteLine($"Town = {Person.Town}");
                Console.WriteLine($"County = {Person.County}");
            }

            Console.ReadKey();
        }
        

        struct Person
        {
            public string FirstName;
            public string SurName;
            public string Street;
            public string Town;
            public string County;
            public int HouseNo;

        }
    }
}
