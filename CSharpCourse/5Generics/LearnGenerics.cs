using System;
using System.Collections;

namespace CSharpCourse._5Generics;

public class LearnGenerics
{
    public static void LearnGenericsMethod()
    {
        // here list is a generic type, it means that list is parameterized by type.

        // var date = new List<int>() {1, 2, 3, 4};
        // Console.WriteLine(date);

        var modlist = new ModList<string>();
        modlist.Add("1");
        modlist.Add("2");
        modlist.Add("3");
        modlist.Add("2");
        modlist.Add("4");
        modlist.ShowList();
        modlist.RemoveAt(2);
        modlist.ShowList();

        IEnumerable<int> nums = [];
        if(!nums.Any())
        {
            Console.WriteLine("nums is empty");
        }

        Tuple<string, int> tuple = Tuple.Create("1", 2);
        Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");

        object[] arr = new object[4];
        arr[0] = 1;
        arr[1] = "hello";

        // Just like List generics collection is a wrapper over array of specified type, ArrayList collection is a wrapper over array of type object.
        // ArrayList has poor performance so we should avoid using it.
        ArrayList _ = [1, 2, 3, 4, "hello", false];

        // We can improve the performance of the list significantly by declaring the size beforehand, so that it doesn't have to be resized when list is full.

        List<int> ints = [1, 2, 3];
        List<string> strings = ["hello", "world"];
        ints.AddToFront(4);
        strings.AddToFront("Hi");

        var decimals = new List<decimal>() { 1.1m, 2.1m, 4.3m };
        Type typeVal1 = decimals.GetType(); // used with objects
        Type typeVal2 = typeof(decimal); // used with type
        Console.WriteLine($"{typeVal1}-{typeVal2}");

        // var decimalArr = decimals.ConvertTo<decimal, int>();

        List<int> listint = new();
    }

    // here constraining T to be an object created from parameterless constructor

    public static IEnumerable<T> GetRandomLengthList<T>(int maxLength) where T: new()
    {
        var randNum = new Random().Next(maxLength + 1);
        var result = new List<T>();
        for(int i = 0; i < maxLength; i++)
        {
            result.Add(new T());
        }

        return result;
    }
} 

// Examples to demonstrate how to create generic methods by create type parameters.

public static class ListExtensions
{
    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> list)
    {
        List<TTarget> targetList = [];
        foreach(TSource item in list)
        {
            // here we can't directly convert type from TSource to TTarget using simple casting
            // we have to use Convert.ChangeType() method which returns object type

            TTarget itemAfterConversion = (TTarget)Convert.ChangeType(item, typeof(TTarget));
            targetList.Add(itemAfterConversion);
        }
        return targetList;
    }

    public static void AddToFront<T>(this List<T> list, T num)
    {
        list.Insert(0, num);
    }
}

public class ModList<T>
{
    private T[] _cont = new T[1];

    public int Length { get; private set; } = 0;

    public void Add(T data)
    {
        if (Length == _cont.Length)
        {
            int newsize = 2 * _cont.Length;
            var _contnew = new T[newsize];
            for (int i = 0; i < Length; i++)
            {
                _contnew[i] = _cont[i];
            }
            _cont = _contnew;
        }
        _cont[Length] = data;
        Length++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Length)
        {
            throw new IndexOutOfRangeException("invalid index");
        }
        for (int i = index + 1; i < Length; i++)
        {
            _cont[i - 1] = _cont[i];
        }
        _cont[Length] = default;
        Length--;
    }

    public void ShowList()
    {
        for (int i = 0; i < Length; i++)
        {
            Console.Write(_cont[i] + " ");
        }
        Console.WriteLine();
    }
}
