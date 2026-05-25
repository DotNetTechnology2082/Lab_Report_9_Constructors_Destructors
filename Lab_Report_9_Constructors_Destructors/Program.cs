using System;

class Student
{
    // Data members
    private string name;
    private int age;

    // Constructor
    public Student(string name, int age)
    {
        // Using 'this' keyword
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
        Student s1 = new Student("Reema", 21);

        // Display data
        s1.Display();

        Console.ReadLine();
    }
}