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
```
mkdir PetManagment
cd PetManagment/
dotnet new sln
dotnet new console -o App
dotnet sln PetManagment.sln add App/App.csproj
dotnet new classlib -o Lib
dotnet sln PetManagment.sln add Lib/Lib.csproj
```

## [Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- Smart fields in C# which are used to expose a private variable outsid the class
- You can use conditionals with your properties.
- properties can be created in 3 ways:
  - read-only - with only get block.
  - write-only - with only set block.
  - read-write property - with both get and set block.

## Method Overloading 
  - Methods with same name in the containing class but with different **Signature**.
  - Signatures can be different in 3 ways:
    - Number of parameters.
    - Datatype of parameters.
    - Sequence of parameters.

## [Abstract class](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members) vs [Interface](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
- An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface. 
- Abstract class allows you to implement a spectrum of abstraction like full abstraction, partial abstraction etc....
- Abstract class allows you to have all types of members. Like you can have data variables and assign values to it and can create methods with definition.
- Abstract class and interface cannot be instantiated but meant to be implemented/inherited.
- Abstract/Concrete class can implement one or more interfaces by which multiple inheritance is achieved. But class can only inherit from 1 class.
- A class can inherit 1 class and one or more interfaces.
```
class A{ }

Class B : A,IA,IB
{ }

interface IA{}

interface IB
```
## [Collections](https://docs.microsoft.com/en-us/dotnet/standard/collections/)
- Similar data can often be handled more efficiently when stored and manipulated as a collection. 
- You can use arrays, non-generic or generics.
- Arrays have fixed size and every element must have a value if no value is provided it contains the default.
- Arrays cannot be grown or shrinked. This where collection solves the problem.
- C# offers 2 categories of Collections:
    - non-generics
    - generics
- **Non-generic** collections store items as Object, require casting. Performance concerns were arised due to this casting and also Garbage Collection.
- **Generic collections** are type-safe at compile time. Because of this, generic collections typically offer better performance. 
- Generic collections accept a type parameter when they are constructed and do not require that you cast to and from.
- All collections provide methods for adding, removing, or finding items in the collection.
- All collections can be **enumerated** by virtue of **Enumerator**.
- An enumerator can be thought of as a movable pointer to any element in the collection.
- Types of Collections:
    - Stack - LIFO (Push, Pop, Peek)
    - Queue - FIFO (Enqueue, Dequeue, Peek)
    - List - Like any array which can grow and shrink dynamically.
    - Dictionary<Tkey,TValue> - Key Value Pair
    - LinkedList - Each element points to next.
- You can query your collections using [LINQ](https://www.tutorialsteacher.com/linq/linq-tutorials). You can query using query Syntax or Method Syntax.
## [Memory Management in .Net](https://medium.com/c-programming/c-memory-management-part-1-c03741c24e4b)
- The GC allocates heap segments where each segment is a contiguous range of memory.
- Objects are allocated in contiguous blocks of memory.
- To mitigate fragmentation, when the [Garbage COllector](https://medium.com/c-programming/c-memory-management-part-3-garbage-collection-18faf118cbf1) frees memory, it tries to defragment it. This process is called **compaction**.
- Objects placed in the heap are categorized into one of 3 generations: 0, 1, or 2. 
- The generation determines the frequency the GC attempts to release memory on managed objects that are no longer referenced by the app. 
- Lower numbered generations are GC'd more frequently.
- Objects are moved from one generation to another based on their lifetime. 
- As objects live longer, they are moved into a higher generation. 
- As mentioned previously, higher generations are GC'd less often. 
- Short term lived objects always remain in generation 0. 
- For example, objects that are referenced during the life of a web request are short lived. 
- Application level singletons generally migrate to generation 2.

- **What is a finalizer?**
    - Finalizers (which are also called destructors) are used to perform any necessary final clean-up when a class instance is being collected by the garbage collector. Some important points about finalizers are:
    - A class can have only one finalizer.
    - A finalizer does not have modifiers or parameters.
    - Finalizers cannot be called explicitly, they are called by the garbage collector (GC) when the GC considers the object eligible for finalization. 
    - They are also called when the program finishes in .NET framework applications.
```
    class Person
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() //constructor
        {
            //initialization statements
        }

        ~Person() //finalizer (destructor)
        {
            //cleanup statements
        }
    }
```
- Finalizers called inhertiance chain: finalizers are called recursively for all instances in the inheritance chain, from the most-derived to the least-derived.

```
    class Person
    {
        ~Person() //finalizer (destructor)
        {
            //cleanup statements
            Console.WriteLine("Person's finalizer is called.");
        }
    }

    class Employee : Person
    {
        ~Employee()
        {
            //cleanup statements
            Console.WriteLine("Employee's finalizer is called.");
        }
    }

    class Manager : Employee
    {
        ~Manager()
        {
            //cleanup statements
            Console.WriteLine("Manager's finalizer is called.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
        }
    }
```

- **Native memory**
    - Some .NET Core objects rely on native memory. 
    - Native memory can not be collected by the GC. 
    - The .NET object using native memory must free it using native code.
    - .NET provides the IDisposable interface to let developers release native memory. 
    - Even if Dispose is not called, correctly implemented classes call Dispose when the finalizer runs.

- **What is Dispose Method?**
    - We mentioned above that finalizers are called by the garbage collector or when the program finishes (in .NET framework applications). 
    - This means we cannot call them. 
    - If our application uses an expensive external resource, we should then release the resource explicitly. 
    - We can do this by implementing Dispose method from IDisposable interface. 
    - By this way, we can improve the performance of our application as well. Now, let’s see this in practice.

- **How to Implement Dispose Method?**
    - First, we create a class that implements IDisposable interface and then choose Implement interface with Dispose pattern.
```
   class DatabaseConnection : IDisposable
    {

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DatabaseConnection() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
```
- Ex:
```
    class DatabaseConnection : IDisposable
    {

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Console.WriteLine("This is the first call to Dispose. Necessary clean-up will be done!");

                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    Console.WriteLine("Explicit call: Dispose is called by the user.");
                }
                else
                {
                    Console.WriteLine("Implicit call: Dispose is called through finalization.");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                Console.WriteLine("Unmanaged resources are cleaned up here.");

                // TODO: set large fields to null.

                disposedValue = true;
            }
            else
            {
                Console.WriteLine("Dispose is called more than one time. No need to clean up!");
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~DatabaseConnection()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
           // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        } 
        #endregion

    }
```

- Now, we can use DatabaseConnection class in order to see how Dispose pattern acts in different scenarios.
```
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new DatabaseConnection();
            try
            {
                //Write your operational code here
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
```

- Another and commonly used method to call Dispose is using using statement:

```
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new DatabaseConnection())
            {
                //Write your operational code here
            }
        }
    }
```
- As you see there is no call to Dispose method because the using statement handles that automatically.
- Both codes above generate the same output.

## [File Handling In C#](https://www.tutorialspoint.com/csharp/csharp_file_io.htm)
- **System.IO** namespace provides four classes that allow you to manipulate individual files, as well as interact with a machine directory structure.
- The **Directory** and **File** directly extends System.Object and supports the creation, copying, moving and deletion of files using various static methods.
    -  They only contain static methods and are never instantiated.
- The **FileInfo** and **DirectoryInfo** types are derived from the abstract class **FileSystemInfo** type and they are typically, employed for obtaining the full details of a file or directory because their members tend to return strongly typed objects.
    - They implement roughly the same public methods as a Directory and a File but they are stateful and the members of these classes are not static.

## Serialization :
- Serialization is the process of converting an object into a form that can be readily transported. For example, you can serialize an object and transport it over the Internet using HTTP between a client and a server. 
- On the other end, deserialization reconstructs the object from the stream.
- The most common formats of serializations are:
    - [XML](https://docs.microsoft.com/en-us/dotnet/standard/serialization/introducing-xml-serialization): XML serialization serializes only the public fields and property values of an object into an XML stream. 
        - You can use [XML Serializer]() class to serialize your objects.
        - The following items can be serialized using the XmlSerializer class:
            - Public read/write properties and fields of public classes.
            - Classes that implement ICollection or IEnumerable.
    - JSON

- [Delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates): Type Safe function pointers. Delegates are tied to method of same type, which means delegate's declaration should match with function declration. There are 2 types of delegates:
    1. Single cast delegate - which holds single method.
    2. Multi cast delegate - which holds more than one method.
- Delegates are the building blocks of event.
- Delegates are used to create anonymous methods and lambda expresssions
- There are a few predefined delegates in C#:
    - Action<>() -> this is a delegate of type void
    - Func<>(T, T) -> this delegate has a return type.
    - Predicate() -> returns bool

## References
- [Memory Management](https://medium.com/c-programming/c-memory-management-part-1-c03741c24e4b)
- [Finalize and Dispose](https://medium.com/c-programming/c-memory-management-part-2-finalizer-dispose-d3b3e43c08d1)

