using System;

class Student
{
    // Data members
    string name;
    int age;

    // Constructor
    public Student(string name, int age)
    {
        // Using this keyword
        this.name = name;
        this.age = age;
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }

    // Destructor
    ~Student()
    {
        Console.WriteLine("Destructor called.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object creation
        Student s1 = new Student("Rahul", 22);

        // Display data
        s1.Display();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}