
namespace CSharpCourse._3Oops;

/*

Currently, the StringsProcessor, StringsTrimmingProcessor, and StringsUppercaseProcessor classes are not implemented.

Let's understand what happens in the ProcessAll method. It takes a List of strings as a parameter. Inside, it has a collection of StringsProcessor objects. Those objects expose a Process method, which also takes a List of strings and returns the same type.

The StringsTrimmingProcessor class has a method that takes a collection of strings and, as a result, returns an identical collection, but with each word trimmed by half. So, for example, for the following input:

"bobcat", "wolverine", "grizzly"

It shall return:

"bob", "wolv", gri"

To cut a string in half, you can use the Substring method.

The StringsUppercaseProcessor class has a method that takes a collection of strings and, as a result, returns an identical collection, but with each word made uppercase. So, for example, for the following input:

"bobcat", "wolverine", "grizzly"

It shall return:

"BOBCAT", "WOLVERINE", "GRIZZLY"

Because both those transformations will be applied to the collection of strings in the ProcessAll method, it should return the collection like the input collection, but with each word both trimmed and made uppercase.

For example, for the following input:

"bobcat", "wolverine", "grizzly"

The result of the ProcessAll method should be:

"BOB", "WOLV", "GRI"

Your job is to create the implementations of the following classes:

StringsProcessor (base)

StringsUppercaseProcessor (derived)

StringsTrimmingProcessor (derived)

Try to avoid code duplication as much as possible.

*/

public class RuntimePolymorphismPractice
{
    public List<string> ProcessAll(List<string> words)
    {
        var stringsProcessors = new List<StringsProcessor>
            {
                new StringsTrimmingProcessor(),
                new StringsUppercaseProcessor()
            };

        List<string> result = words;
        foreach (var stringsProcessor in stringsProcessors)
        {
            result = stringsProcessor.Process(result);
        }
        return result;
    }
}

// implement here
public class StringsProcessor
{
    public List<string> Process(List<string> input)
    {
        var output = new List<string>();
        foreach(var str in input)
        {
            output.Add(GetProcessedString(str));
        }
        return output;
    }
    
    protected virtual string GetProcessedString(string str)
    {
        return str;
    }
}

public class StringsTrimmingProcessor : StringsProcessor
{
    protected override string GetProcessedString(string str)
    {
        return str[..(str.Length / 2)]; // finding substring from ind 0 and substring of length, n / 2 => str.Substring(0, str.Length / 2)
    }
}

public class StringsUppercaseProcessor : StringsProcessor
{
    protected override string GetProcessedString(string str)
    {
        return str.ToUpper();
    }
}
