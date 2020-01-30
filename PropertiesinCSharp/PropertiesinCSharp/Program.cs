using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passMark = 35;

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student ID cannot be zero or negative");
            }
            this._id = value;
        }

        get
        {
            return _id;
        }
    }

    public string Name
    {
        set
        {
            if (value == null)
            {
                throw new Exception("student name cannot be empty");
            }
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(_Name) ? "No Name" : this._Name;
        }
    }

    public int PassMark
    {
        get
        {
            return _passMark;
        }
    }

    public string City { set; get; }
    public string Email { set; get; }
}

class Program
{
    static void Main()
    {
        Student S1 = new Student();

        S1.Id = 786;
        S1.Name = "Jon Dow";
        //S1.PassMark = 45; // Compilation error, PassMark property is readonly as it as only 'get' accessor)
        S1.City = "SomeCity";
        S1.Email = "Jon.Dow@xyz.com";

        Console.WriteLine($"Student ID - {S1.Id}; Student Name - {S1.Name}; PassMark - {S1.PassMark};Student from - {S1.City}; Student Email - {S1.Email}");

        Student S2 = new Student();
        //S2.Id = 0; // Throws student ID cannot be Zero or Negative exception.
        //S2.Name = null // Throws strudent Name cannot be null exception.

        Student S3 = new Student() //Object initializer syntex introduced in C# 3.0
        {
            Id = 7786,
            Name = "Jo Jos",
            City = "SameCity",
            Email = "Jo.Jos@xyz.com"
        };
        
        Console.WriteLine($"Student ID - {S3.Id}; Student Name - {S3.Name}; PassMark - {S3.PassMark};Student from - {S3.City}; Student Email - {S3.Email}");

        Console.ReadKey();
    }
}