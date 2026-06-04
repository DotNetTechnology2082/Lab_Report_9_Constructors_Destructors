using System;

class Student
{
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
        Console.WriteLine("Destructor called.");
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Anuj", 20);
        s.Display();
    }
}