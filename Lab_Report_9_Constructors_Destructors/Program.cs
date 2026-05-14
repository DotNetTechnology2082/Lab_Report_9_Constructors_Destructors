using System;

class Student
{
    // Data members
    private string name;
    private int age;

    public Student(string name, int age)
    {
        
        this.name = name;
        this.age = age;

        Console.WriteLine("Constructor Called!");
    }

    //Method to display data
    public void Display()
    {
        Console.WriteLine("Student Name: " + this.name);
        Console.WriteLine("Student Age: " + this.age);
    }

    //Destructor
    ~Student()
    {
        Console.WriteLine("Destructor Called!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Creating object
        Student s1 = new Student("Suvam", 20);

        //Display object data
        s1.Display();

        //Wait for user input
        Console.ReadLine();
    }
}