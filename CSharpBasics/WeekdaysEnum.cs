using System;

namespace CSharpBasics
{
    public enum Weekdays
    {
        Monday,
        Tuesday, 
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };

    public static class StringExtension
    {
        public static string ReverseStr(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
