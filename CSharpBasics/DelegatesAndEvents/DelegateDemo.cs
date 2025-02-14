namespace CSharpBasics.DelegatesAndEvents;

public delegate int MyDelegate(int num);
public delegate T Add1<T>(T num1, T num2); // generic delegate
public delegate T Add2<T, W, Z>(W num1, Z num2); // generic delegate with 3 generic parameters

public class DelegateDemo
{
    public static int Func(int num)
    {
        return num + 1;
    }

    public static void Method2(MyDelegate func)
    {
        func.Invoke(4);
        return;
    }

    public static void DelegateDriverMethod()
    {
        MyDelegate myDelegate1 = (int num) => num + 1;
        MyDelegate myDelegate2 = (int num) => num + 2;
        MyDelegate myDelegate3 = (int num) => num + 3;
        // int res = myDelegate(2)
        // Console.WriteLine(res);

        // Delegate d = new();
        // int res1 = d.myDelegate1.Invoke(2);
        // Console.WriteLine(res1);

        // static int method(int num)
        // {
        //     return num;
        // }
        // Method2(method);

        // multicast delegate
        MyDelegate myDelegate = myDelegate1 + myDelegate2 + myDelegate3;
        Console.WriteLine(myDelegate.Invoke(2));
    }

    // inbuilt delegate with one input type, one return type and refers to a function
    internal Func<int, int> myDelegate1 = (int num) => num * num;
}
