using System;

namespace CSharpBasics.AbstractModifier;

abstract class SomeClass
{
    private int field1;
    protected abstract int MyProperty { get; set; }
    public static int staticField;
    public static int SomeProperty { get; set; }

    public SomeClass(int field1)
    {
        this.field1 = field1;
    }

    public static void StaticMethod()
    {
        staticField ++;
    }

    public virtual void SomeMethod() 
    {
        return;
    }

    public abstract void SomeAnotherMethod();
}
