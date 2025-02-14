using System;

namespace CSharpBasics.Datatypes;

public class Datatype
{
    public static void LearnDatatype()
    {
        int numb; // variable can be used after it is initialized and declared
        //Console.WriteLine(numb); // compilation error

        // here int is an alias representing struct Int32 which is ValueType
        int num = 1;
        Console.WriteLine(num);

        decimal decivar = 12.223m; // cannot implicitly convert double to decimal
        Console.WriteLine(decivar);

        // no alias for representing unsigned integer
        uint num2 = 2;
        Console.WriteLine(num2);
    }
}