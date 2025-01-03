# Generic Array in C# - A Simple Implementation

This repository contains a C# implementation of a generic array class. The goal of this project is to explore and understand the use of **generics** in C#, focusing on type safety, reusability, and creating flexible data structures.

## Features
- **Generic Data Structure:** A custom class that can store any type of data.
- **Type Safety:** Ensures type consistency with the use of generics.
- **Simple and Scalable:** Can easily be extended or modified to fit specific needs.

## Key Concepts
- **Generics** in C# allow for the creation of reusable classes that can work with any data type while maintaining type safety.
- The `this` keyword is used for indexing, allowing the class to behave similarly to a native array.

## Code Example

```csharp
MyArray<int> intArray = new MyArray<int>();
intArray.AddElementArray(1);
Console.WriteLine(intArray[0]); // Output: 1

MyArray<string> stringArray = new MyArray<string>();
stringArray.AddElementArray("Hello, World!");
Console.WriteLine(stringArray[0]); // Output: Hello, World!
