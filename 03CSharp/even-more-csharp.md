# Week 3: Even More CSharp
Comment/XML Doc, Variance/Type Checking, Exception Handling, Non-access modifiers

## Semantic Code with Comments (inline, XML)
* inline comment //
* block comment /* */
* XML Documentation ///
///<summary></summary>
///<remarks></remarks>
///<params></params>

## Deeper dive into C#'s types
### Type Casting Review:
    long a = 10;
    //explicit conversions
    int b = (int)a;
    b = Int32.Parse("10");
    b = Convert.ToInt32(a);

### Boxing and Unboxing
Boxing and unboxing in C# is wrapping a value type in an object
It allows value types to tap into reference type functionalities

### Another Review: Parameter Modifier
* Out
    - Get additional outputs other than what the function returns
    - May or may not be initialized before, but the function need to set it before it finishes executing
* Ref
    - Used to pass params by reference.
    - Must be initialized beforehand
* In
    - Also used to pass params by reference
    - But ensures that the value does not change
    - Modifier not necessary at call time

## Variance and Type Checking
### Variance
Variance is a special type of polymorphism that is used in generic collections and delegates.
Three types of variance:
* Covariance: A more derived type can be used in place of its original type
* Contravariance: A less derived type can be used in place of its original type
* Invariance: no type casting, nada.

### Type Checking
* typeof: Gets type name during compilation time. Takes datatype as argument (not the variable!)
* GetType: Gets type during run time
* Is
* As
[MSDoc](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast)

## Exception Handling
* Try
* Catch
* Finally
* Throw / Throw ex
* Custom Exception

## Non-access modifiers
* Abstract
* Const
* New
* Override
* Partial
* Readonly
* Sealed
* Static
* Virtual

## OOP(Object-Oriented Programming)
- Procedural Oriented languages - C, C++
  - The code scattered - variables, functions were loose and no structure.
  - Data leak due to garbage, that means data is less secure.
  - What to do and How to do?
  - Resuability wasn't a great option in Procedural oriented language.
- OOP
  - In OOP the program is organized into classes and accessed via object.
  - Programmer focus on what to do over how to do.
  - **[Class](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes)**: Blueprint of user defined type which is mapped to real time entities. Ex: Pen can be created as class with attributes/properties - type (ball, ink), color (blue, black, red, green) , behavior (writing).
  - **Object**: An object is a implementation of the class. It has been allocated memory. Whenever a class is instantiated the obj comes into the picture.
    - `Pen pen1 = new Pen();`, `Pen pen2 = pen1`.
    - Object has set of attributes/properties (static/dynamic)
    - Behaviour/Operations
  
  - **Pillars of OOP**
    - [OOP](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop) is structured on 4 pillars of OOP as:
      - **Encapsulation** - Wrapping up of the data (ex - methods encloses data field, class/Type encloses a method, namespace encapsulates the type) and data hiding, to provide protection from the outside world. We use Access modifiers to provide various levels of access.
      - **Abstraction** - Showing only essential features of the program instead on un-necessary details. In C#, abstraction can be achieved by **abstract** classes and **interfaces**. Through abstraction a template is provide which is generally impltemented by Team of Software Developers.
      - **Inheritance** - Is a way to extend a type so that its properties and behaviours can be extended/branched further. Types of Inheritance:
        - Single - level: A->B
        - Multi - level: A->B->C
        - Hierarichal level A->B,C,D
        - Multiple inheritance - (A,B)->C
        - Hybrid inheritance - Combination of more than one above types of inheritance.
      - C# doesnot support multiple and hybrid inheritance.
      - **Polymorphism** - Poly - many, morphs - forms. Ability to implement inherited properties or methods in different ways across multiple abstractions. It can be static/Compile time polymorphism or dynamic/runtime  polymorphism. Ex Method Overloading is an example of compile time polymorphism, which is method with same name behaves differently based on signatures (parameters). Method Overriding is an example of runtime polymorphism, which is re-defining the method of parent class into child class. 
## [Strings](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)

## refactoring of the code demo
- ```
mkdir PetManagment
cd PetManagment/
dotnet new sln
dotnet new console -o App
dotnet sln PetManagment.sln add App/App.csproj
dotnet new classlib -o Lib
dotnet sln PetManagment.sln add Lib/Lib.csproj
```