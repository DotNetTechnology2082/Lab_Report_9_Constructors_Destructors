using System;

namespace LabReport9
{
    class Student
    {
        // Data members
        string name;
        int age;

        // Constructor
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Destructor
        ~Student()
        {
            Console.WriteLine("Destructor called for Student object");
        }

        // Method to display data
        public void Display()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating object and initializing values
            Student s1 = new Student("Suman", 20);

            // Displaying data
            s1.Display();

            // Forcing garbage collection (only for demo purpose)
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\nEnd of Program");
        }
    }
}