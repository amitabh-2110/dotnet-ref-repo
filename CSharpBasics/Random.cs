using System.Text;

namespace CSharpBasics;

interface IDemo
{
    public int id { get; set; }
}

// class is reference type
class Demo: IDemo
{
    public int id { get; set; }
}

class Random
{
    public static void DriverMethod()
    {
        // Camel case convention should be used when defining variables.
        // Pascal case convention should be used when defining class and methods.

        // Object initializer when we don't want to call constructor
        Demo demo = new Demo 
        {
            id = 1
        };

        Demo d1 = demo;
        Demo d2 = demo;

        d2.id = 2;
        Console.WriteLine($"{d1.id} {d2.id}");

        StringBuilder stringBuilder = new StringBuilder("hello world"); // StringBuilder is mutable and System.String is immutable
        stringBuilder[0] = 'a';
        Console.WriteLine(stringBuilder.ToString());

        // Array class also inherits from IEnumerable
        // Array is an abstract class
        Demo[] demoarray = [new Demo { id = 1 }, new Demo { id = 2 }];
        int n = demoarray.Length;
        foreach(IDemo demoObj in demoarray)
        {
            Console.WriteLine($"{demoObj.id}");
        }

        Demo[,] demoTwoDimensionalArray = new Demo[5, 4];
        int row = demoTwoDimensionalArray.GetLength(0); // .GetLength(0) property returns the size of first dimension
        int cols = demoTwoDimensionalArray.GetLength(1); // .GetLength(1) property returns the size of second dimension
        Console.WriteLine($"{row} {cols}");

        Demo[][] demoJaggedArray = new Demo[4][];
        int nums = demoJaggedArray.GetLength(0);
        Console.WriteLine($"{nums}");

        int score = 0;
        switch(score)
        {
            case 0:
                Console.WriteLine("case 0 matched");
                break;
            case 1:
            case 2:
            case int x when x > 3:
            default:
                Console.WriteLine("default case");
                break;
        }

        return;
    }
}
