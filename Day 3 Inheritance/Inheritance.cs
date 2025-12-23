using System;

namespace MyConsoleApp
{
    // Base class
    class Person(int id, string name, int age)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
    }

    // Derived class for Man
    class Man(int id, string name, int age, string play) : Person(id, name, age)
    {
        public string Play { get; set; } = play;
    }

    // Derived class for Woman
    class Woman(int id, string name, int age, string playManage) : Person(id, name, age)
    {
        public string PlayManage { get; set; } = playManage;
    }

    // Derived class for Child
    class Child(int id, string name, int age, string watchingCartoon) : Person(id, name, age)
    {
        public string WatchingCartoon { get; set; } = watchingCartoon;
    }

    // Main class with the entry point
    class Inheritance
    {
        static void Main(string[] args)
        {
            // Creating objects
            Person person = new(1, "John", 30);
            Man man = new(2, "Mike", 25, "Football");
            Woman woman = new(3, "Sarah", 28, "Gardening");
            Child child = new(4, "Tommy", 5, "Tom and Jerry");

            // Display information for each person
            GetDetails(person);
            GetDetails(man);
            GetDetails(woman);
            GetDetails(child);
        }

        // DisplayInfo method for showing person details

        static void GetDetails(Person person)
        {
            string result = string.Empty;
            if (person is Man man)
            {
                Console.WriteLine($"ID: {man.Id}, Name: {man.Name}, Age: {man.Age}, Play: {man.Play}");
            }
            else if (person is Woman woman)
            {
                Console.WriteLine($"ID: {woman.Id}, Name: {woman.Name}, Age: {woman.Age}, PlayManage: {woman.PlayManage}");
            }
            else if (person is Child child)
            {
                Console.WriteLine($"ID: {child.Id}, Name: {child.Name}, Age: {child.Age}, WatchingCartoon: {child.WatchingCartoon}");
            }
        }
        
    }
}