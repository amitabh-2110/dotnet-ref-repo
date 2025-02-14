# Constant and Readonly variables

## Constant variables
- Once constant variable is declared at compile time, its value can't be changed throughout the application.
- Constant variable field member present inside a class can be accessed outside of a class using "Classname.variable-name".

## Readonly variables
- After declaring a readonly variable as a member, we can change its value inside the constructor (means at the time of creation of objects). Else, we **cannot** change its value inside a method.
- That's why we can say that readonly variables once declared at compile time, its value can be changed at runtime.
- Readonly variable cannot be declared locally i.e. inside a method and must be a member variable of a class.
