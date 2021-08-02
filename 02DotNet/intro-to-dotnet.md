# Welcome to .NET

## What is .NET?
.NET is an open source developer platform created by Microsoft. It's for building many different types of apps, such as web apps, desktop apps, and games.
In short, .NET Platform is a collection of languages, libraries, and frameworks to make various applications, developed under one common standard.

## Supported Programming Languages
3 different languages
- C#: Object oriented, type safe language
    - object oriented means, that everything is an object. These objects are further organized with classes
    - Type-safe means that once you declare a type of a variable, you can't really change it. 
- Visual Basic
- F#: F# is a functional programming language supported by .NET

## Technologies we'll be using during this training
- .NET 5 and C#
- SQL 
- ASP.NET Core for creating web applications
- Azure Cloud Service for hosting and DevOps
- Javascript, Typescript, HTML, CSS, and Angular for frontend

## .NET Implementation
4 main implementation of .NET 
- **.NET Framework**: first implementation of .NET, only works on windows, and it is shipped with every windows.
- **.NET / .NET Core**: .NET Core is the cross-platform implemtation of .NET, and is a successor of .NET Framework. 
    - This is a primary implementation of .NET and is the focus of ongoing development effort. This what we'll be using.
    -.NET 5
- **Mono**
    - .NET runtime that power Xamarin application. 
    - useful when small footprint is needed
    - also powers games built with Unity
- **Universal Windwos Platform (UWP)**
    - Used for building modern, touch-enabled Windows applications and software for the Internet of Things (IoT). 
    - It's designed to unify the different types of devices that you may want to target, including PCs, tablets, phones, and even the Xbox.

## Components of .NET Implementation
    - One or more runtime: Example, .NET Framework CLR, .NET 5 CLR
        - CLR stands for *Common Language Runtime* and it's a runtime environment provided by .NET
    - A class library, for example, .NET Framework Base Class Library, or .NET 5 Base Class Library.
    - Optionally, we have one or more application frameworks, such as ASP.NET Core for web application development, Windows Forms, etc.
    - Optionally, development tools. Some are shared among multiple implementations.

#### CLR? SDK?
CLR Stands for Common Language Runtime, and it's runtime environment
SDK stands for Software Development Kit.
CLR comes included in SDK

## .NET Standard
.NET Standard is a base set of API's that are common to all .NET implementation.

### Additional Frameworks
These are frameworks that extend .NET platform to provide additional functionalities.
- **ASP.NET Core**: Open source framework for building web apps and web services
    - it's a redesign on ASP.NET 4.x with architectural changes that result in a lener, more modular framework
- **Unity**: Real-time 3D development platform
- **UWP (Universal Windows Platform)**: for developing various windows applications
- **Xamarin**: for mobile development
- **ML.NET**: machine learning
- and more..

### Other Niceties..
- **Nuget**: a package manager for .NET

.NET 5
ASP.NET: ASP.NET Core to match with .NET Core 

### Additional Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- [.NET Glossary](https://docs.microsoft.com/en-us/dotnet/standard/glossary)
- [Introducing .NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/)
- [What is .NET?](https://www.codecademy.com/articles/what-is-net)