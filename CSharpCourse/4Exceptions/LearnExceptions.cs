
namespace CSharpCourse._4Exceptions;

// types of exceptions - 
// 1. ArgumentException - 
// 1.a. ArgumentNullException
// 1.b. ArgumentOutOfRangeException
// 2. FormatException
// 3. IndexOutOfRangeException
// 4. InvalidOperationException
// 5. NotImplementedException
// 6. NullReferenceException

public class LearnExceptions
{
    public static void ExceptionMain()
    {
        // try
        // {
        //     int num = ParseStringToInt("hello"); // maybe some database connection opened and exception occured
        //     Console.WriteLine($"{num} parsed successfully");
        // }
        // catch
        // {
        //     Console.WriteLine("Exception thrown"); // handled the exception here
        // }
        // finally
        // {
        //     Console.WriteLine("finally block executed"); // database connection closed here
        // }

        try
        {
            Console.WriteLine(IsFirstElementPositive([]));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); // can return response to user with status code and message specific to invalid operation
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int ParseStringToInt(string str)
    {
        try
        {
            int num = AnotherLevel(str);
            return num;
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"parse string to int exception occured - {ex.Message}");
            // used to rethrow the same exception caught to the higher calling method
            // also it preserves the stack trace
            throw;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"can't divide by zero exception occured - {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error occured - {ex.Message}");
            throw;
        }
    }

    public static int AnotherLevel(string str)
    {
        int num = int.Parse(str);
        return num;
    }

    public static bool IsFirstElementPositive(IEnumerable<int> nums)
    {
        try
        {
            return nums.First() > 0;
        }
        catch (InvalidOperationException)
        {
            throw new InvalidOperationException("given list is empty"); // here we are returning exception and not any bool value, but the code still compiles
        }
        catch (NullReferenceException ex)
        {
            throw new ArgumentNullException("given object is null" + ex.Message, ex);
        }
    }
}
