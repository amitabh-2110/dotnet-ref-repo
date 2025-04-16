> References: 
- [Type system hierarchy and data type info](https://github.com/GavinLonDigital/CSharpDataTypesDocumentation/blob/master/C%23%20Data%20Types%20Documentation.pdf)
- [Implicit and explicit data type conversion](https://github.com/GavinLonDigital/DataTypeConversionDocumentation/blob/master/CSharpDataConversionDocumentation.pdf)

# Data types
Data types gives meaning to the data, defines rules on what type of operations can be applied on the data and indicates rules on how data of a particular data 
type is going to be represented in the memory. C# datatypes can be catagorised into two types 
- value type. 
- reference type.

## Common type system hierarchy
All the .NET types follows a common type system hierarchy which is as follows:

Now, the **System.Object** class is the root of the type hierarchy, which means it is the ultimate base class for all .NET classes. All the value types and reference
types inherits from the Object class.

The **System.Object** class has one of the child class called as **System.ValueType**. The **System.ValueType** class is the base class for all C# value types 
e.g. **int, bool, decimal, struct, char, double, enum, float, byte.** The other classes inherits from the Object class are reference types. e.g. **string, delegate,
dynamic, array, datetime**.

- The struct **System.Int32** which uses the alias as **int** inherits from **System.ValueType**. Unlike class is a reference type, struct is a value type means it
stores the copy of value directly into the stack memory.

- An **enum** is a value type and used to create a set of integer constants.

- The **char** which is an alias for struct **System.Char** is also a value type. It is a 16 bit data type and used to hold Unicode values. Each Unicode value is an
encoding of a character. e.g. the character 'f' is represented and stored in the memory by Unicode value of '102'. Here, Unicode is a standard to represent text and
can be implemented by different character encodings.

- The **string** which is an alias for **System.String** is a reference type and immutable, means if we concatenate with other string then everytime it will generate
a new string in a new heap memory location which makes previous strings eligible for garbage collection.

- The **Dynamic** type bypasses the compile time checking and errors are caught at runtime.