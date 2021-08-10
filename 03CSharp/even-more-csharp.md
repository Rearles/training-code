# Week 3: Even More CSharp
Comment/XML Doc, Variance/Type Checking, Exception Handling, Non-access modifiers,

## Semantic Code with Comments (inline, XML)
* inline comment //
* block comment /* */
* XML Documentation ///

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