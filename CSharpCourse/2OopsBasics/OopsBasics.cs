using System;

// namespace is a group of related classes where they can access each other. Generally, namespace represents the file directory.
namespace CSharpCourse._2OopsBasics;

public class Rectangle(int width, int height)
{
    public readonly int Width = width; // default value for int fields are 0 and by default private
    public readonly int Height = height;

    public const int numberOfSides = 4; // const fields are implicitly static
}

public class DoctorAppointment
{
    public readonly string _patientName;
    private DateTime _appointmentDate;

    public int MyProp { get; } // property without setter here is as good as public readonly

    public DoctorAppointment(string patientName, int daysToAdd = 7) // default optional parameters value must be compile time constant and present after all parameters
    {
        _patientName = patientName;
        _appointmentDate = DateTime.Now.AddDays(daysToAdd);
        MyProp = 12;
    }

    // Here we are calling one constructor from another overloaded constructor using "this" keyword instead of repeating code.
    // In this context, "this" refers to the another constructor

    public DoctorAppointment(string patientName): this(patientName, 7)
    {}

    public DoctorAppointment(string patientName, DateTime appointmentDate)
    {
        _patientName = patientName;
        _appointmentDate = appointmentDate;
    }

    public DateTime GetAppointmentDate() => _appointmentDate;

    public void ResheduleAppointment(DateTime resheduleDateTime)
    {
        _appointmentDate = resheduleDateTime;
        var printer = new DoctorAppointmentPrinter();
        printer.Print(this); // here in this context "this" refers to the current instance
    }

    public int ResheduleAppointment(int month, int day)
    {
        _appointmentDate = new DateTime(_appointmentDate.Year, month, day);
        return 1;
    }
}

public class DoctorAppointmentPrinter
{
    public void Print(DoctorAppointment doctorAppointment)
    {
        Console.WriteLine($"doctor appointment: {doctorAppointment.GetAppointmentDate()}");
    }
}

public class Order
{
    private DateTime _date;

    public DateTime Date
    {
        get => _date;
        set
        {
            if(value.Year != DateTime.Now.Year)
            {
                _date = value;
            }
        }
    }
}

public class Person
{
    public string Name { get; set; } = "";
    public int Age { get; init; } // age can be initialized only but cannot be set
}

// here static classes are implicitly sealed means we can't inherit from them
public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) => a / b;
}

public class OopsBasics
{
    public static void OopsBasicsMainMethod()
    {
        var appointment = new DoctorAppointment("patient", new DateTime(2024, 5, 1));
        appointment.ResheduleAppointment(new DateTime(2024, 5, 2));
        appointment.ResheduleAppointment(12, 3);

        // object initializer syntax
        var person = new Person
        {
            Name = "John",
            Age = 30
        };
        //person.Age = 12; // can't access public property
        Console.WriteLine(person);

        int num = Rectangle.numberOfSides; // accessing const field using class name because it is implicitly static
        Console.WriteLine(num);

        // Below, the separators can either be char or string
        // Join is a static method of string class

        string input = "1,2,3,4,5";
        string originalSeparator = ",";
        string targetSeparator = "+";
        string[] numbers = input.Split(originalSeparator); // output will be ["1", "2", "3", "4", "5"]
        Console.WriteLine(string.Join(targetSeparator, numbers)); // output will be "1+2+3+4+5"
    }
}
