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

    // Method to display data
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }

    // Destructor
    ~Student()
    {
        Console.WriteLine("Destructor Called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Namrata", 22);

        s1.Display();

        Console.ReadLine();
    }
}