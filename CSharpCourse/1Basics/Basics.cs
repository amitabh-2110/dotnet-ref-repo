using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using CSharpCourse._2OopsBasics;

namespace CSharpCourse._1Basics;

public class Basics
{
    public static Action<int> BasicMainMethod()
    {
        // var rect = new Rectangle();
        // should be first declared (done) and initialized before use
        // Console.WriteLine(num) will give Compilation error because num is not initiallized
        int num;

        bool isUpperChar = char.IsUpper('a'); // false
        int minInt = int.MinValue;
        int maxInt = int.MaxValue;
        int findMaxAmongInt = int.Max(minInt, maxInt);
        int findMinAmongInt = int.Min(minInt, int.Max(minInt, maxInt));

        // concatenating string and int
        int num1 = 10;
        int num2 = 2;
        Console.WriteLine("hello" + num1 + num2);

        // while using var keyword for a variable we need to initialize it while declaring it
        var num3 = 3;

        // local function
        // using closure, local function can retain variables in the container scope even after the scope has finished execution
        // but static local function can't refer to variables of container method scope
        void PrintNum(int num)
        {
            var num4 = 5;
            void AnotherPrint()
            {
                num4++;
                num1++;
                void Ano()
                {
                    num2++;
                    num4++;
                    num1++;
                    num3++;
                }
                Ano();
            }
            AnotherPrint();
        }

        // static local function
        static void StaticPrintNum()
        {
            int num5 = 0;
            num5++;
            // num1 ++; This is an error
        }
        StaticPrintNum();
        Console.WriteLine("num1:" + num1 + ", num2:" + num2 + ", num3:" + num3);

        var names = new Names();
        Console.WriteLine(names.All.Count);
        // here list is a reference type, means it holds the reference to the list object. So calling Clear() will modify the object not the reference which names.All holds. That's why it works
        // names.All.Clear(); error
        Console.WriteLine(names.All.Count);


        return PrintNum;
    }

    public static void BasicMethod()
    {
        // Get the absolute value of a -ve number
        int num = -5;
        Console.WriteLine(Math.Abs(num));

        // Converting string to int using int.Parse() method, if passed string doesn't represent number, it will throw an exception
        var str = "123";
        Console.WriteLine(int.Parse(str));

        bool isConvertStrToIntSuccess = int.TryParse(str, out int res);
        if (isConvertStrToIntSuccess)
        {
            Console.WriteLine(res);
        }
        else
        {
            Console.WriteLine("invalid string");
        }

        // an array of size 5 initialized with some values and accessing its last value
        // an array is a collection whose size is fixed
        var nums1 = new[] { 1, 2, 3, 4, 5 };
        Console.WriteLine($"last num: {nums1[^1]}");

        // initializes an array with -1 whose default value is 0
        int[] nums2 = new int[5];
        Array.Fill(nums2, -1);

        // 2D array declaration and initialization
        int[,] multinum = new int[3, 3];
        int n = multinum.GetLength(0), m = multinum.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                multinum[i, j] = -1;
            }
        }

        // here variable numb in the foreach loop is only readonly and can't be assigned values
        foreach (var numb in nums1)
        {
            Console.WriteLine(numb);
        }

        // a list another collection whose size is not fixed
        List<int> list = new List<int>();
        list.Add(0);
        list.Add(1);
        list.Remove(0);
        Console.WriteLine($"list cap: {list.Count}");
    }
}

class Names 
{
  public IReadOnlyList<string> All { get; } = ["1", "2", "3"];
}
