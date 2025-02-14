using System;

namespace CSharpBasics.AbstractModifier;

class SomeDerivedClass: SomeClass
{
    public SomeDerivedClass(int field1): base(field1) {}

    protected override int MyProperty { get; set; }

    public override void SomeAnotherMethod()
    {
        return;
    }
}
