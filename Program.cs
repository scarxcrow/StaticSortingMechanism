namespace SortingMechanism_Static
{
    internal class Program
    {
        public delegate int Comparison<T>(T x, T y);

        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person { Name = "Mishata", Age = 24 },
                new Person { Name = "Denis", Age = 28 },
                new Person { Name = "Rumqna", Age = 57 },
                new Person { Name = "Nikolai", Age = 54 }
            };


            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);


            Console.WriteLine("Sorting by age: ");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }


            sorter.Sort(people, CompareByName);


            Console.WriteLine("Sorting by name: ");
            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            Console.ReadKey();
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
