using System;

namespace CSharpBasics.ReadonlyAndConstant
{
    public class Program
    {
        const int SpeedOfLight = 3000000; // value can't be changed, once its declared at the compile time.
        private readonly int DistanceToMars = 13; // value can be changed at runtime once declared at compile time.

        public Program()
        {
            DistanceToMars = 23;
        }

        public void SomeMethod()
        {
            // error
            // readonly Int32 num = 0;
            return;
        }
    }
}
