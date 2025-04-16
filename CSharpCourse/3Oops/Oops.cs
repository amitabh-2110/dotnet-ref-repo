
namespace CSharpCourse._3Oops;

public class Oops
{
    public static void OopsDriverMethod()
    {
        /* Here compiler will try to access the property from Base class type i.e. Animal, because compiler doesn't know about the assigned instance members. When compiler saw the property is being declared using virtual keyword, this indicates that it may be overridden using derived class, so at runtime c# uses assigned instance type class, if the accessed property is declared using override keyword then this property defined in the instance class will be accessed otherwise, base class property will be accessed. */

        Animal animal = new Tiger(4); // also called upcasting
        Console.WriteLine(animal.Name); 

        /* Here writeline method accepts instances of type object (which is the root of the type heirarchy) and calls the method ToString() on that instance, since the writeline method accepts the object type, the ToString() method of object class is called. Since, every class is derived from the object base class we can override the ToString() method of object type and provide our own implementation, e.g. to describe the object. */

        var tiger = new Tiger(4);
        Console.WriteLine(tiger);
        Console.WriteLine(tiger is Tiger); // using is operator to check variable belongs to which class type

        /* The difference between explicit casting and casting using "as" operator is that when explicit casting fails a runtime error is thrown but casting using "as" opertor fails then it just assignes null. */
    }
}

// here try to analyse which things can be kept common in base class and what things can have their own implementations.
// abstact class is just an abstract concept
public abstract class Animal
{
    // here virtual tells the c# compiler that this member may be overridden by a derived class with its own implementation
    public virtual string Name { get; } = "Animal class";

    // static members can't be overridden in derived class because they belong to their class, therefore no point in providing different implementation for it
    protected static string Hello = "";

    protected int NumberOfLegs { get; set; }

    public Animal(int numberOfLegs)
    {
        NumberOfLegs = numberOfLegs;
    }

    // if we want to override a method in the derived class then the method signature should be same (inc. return type and parameters)
    // virtual method must have body
    public virtual void Walk()
    {
        Console.WriteLine("Animal is walking");
    }

    // here the abstract method forces the derived class to override it and abstract members are implicity virtual and don't have body
    public abstract void Talk();
}

// multiple inheritance (derived class inherits from multiple base classes at the same time) is not supported in c# due to diamond problem. 

public class Tiger: Animal
{
    public override string Name { get; } = "Tiger class";

    public Tiger(int numberOfLegs) : base(numberOfLegs) {} // Here first base class constructor shall be executed

    public override void Walk()
    {
        Console.WriteLine($"Tiger is walking using {NumberOfLegs} legs");
        return;
    }

    // here the overridden ToString() will be accessible to derived classes of this class also
    public override string ToString()
    {
        return Hello;
    }

    // overrides the abstract method of the base class
    public override void Talk()
    {
        throw new NotImplementedException();
    }
}

// here the human class is escaped from overriding the abstract class member because it is also marked as abstract
// can't create instances
public abstract class Human : Animal
{
    public Human(int numberOfLegs): base(numberOfLegs) {}
}

// Here can't derive from string class because string is marked as sealed
// public class MySpecialString: String {}
