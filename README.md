# cSharp Tips
This repository contains a collection of tips and tricks for C# programming. Each tip is designed to help you write cleaner, more efficient, and more maintainable code.
## Table of Contents
- [cSharp Tips](#csharp-tips)
  - [Table of Contents](#table-of-contents)
  - [Tip 1: Method vs Function](#tip-1-method-vs-function)
  - [Tip 2: Parameter Vs Argument](#tip-2-parameter-vs-argument)
  - [Tip 3: Constructors](#tip-3-constructors)
    - [Note](#note)
  - [Tip 4: Static field vs Const](#tip-4-static-field-vs-const)
  - [Tip 5: Using Static Statements](#tip-5-using-static-statements)
  - [Tip 6: Destructor vs Deconstructer](#tip-6-destructor-vs-deconstructer)
  - [Tip 7: Value vs Reference Type](#tip-7-value-vs-reference-type)
  - [Tip 8: String type is a class](#tip-8-string-type-is-a-class)
  - [Tip 9: Boxing vs Unboxing](#tip-9-boxing-vs-unboxing)
  - [Tip 10: OOP](#tip-10-oop)
  - [Tip 11: Interface Implementation Means](#tip-11-interface-implementation-means)
  - [Tip 12: Why we need Garbage Collector](#tip-12-why-we-need-garbage-collector)
  - [Tip 13: Delegates](#tip-13-delegates)
  - [License](#license)
  - [Contact](#contact)



## Tip 1: Method vs Function
A **function** is a block of code that performs a task and can exist independently.  
A **method** is a function that belongs to an object or class.
بالعربي و مختصر الكلام
الوظيفة (Function) هي قطعة من الكود تقوم بمهمة معينة ويمكن أن توجد بشكل مستقل علما أنه في سي شارب لا يوجد كود يكتب خارج كلاس بالعموم.
الطريقة (Method) هي مجموعة التعليمات و الوظائف مثل العمليات الحسابية و غيرها من عمليات معالجة أو استدعاء بيانات إلخ.. و كل ذلك ضمن بلوك ينتمي لكلاس حصرا, بالتالي في برمجة كائنية التوجه كل الدوال هي طرق

## Tip 2: Parameter Vs Argument
A **parameter** is a variable in the declaration of a function or method.
An **argument** is the actual value that is passed to the function or method when it is called.

Example:

```csharp
public void PrintMessage(string message) // 'message' is a parameter
{
    Console.WriteLine(message);
}
PrintMessage("Hello, World!"); // "Hello, World!" is an argument
```

بالعربي و مختصر الكلام
المُعامل (Parameter) هو متغير يتم تعريفه في توقيع الدالة أو الطريقة.
الحُجَّة (Argument) هي القيمة الفعلية التي يتم تمريرها إلى الدالة أو الطريقة عند استدعائها.


## Tip 3: Constructors
A **constructor** is a special method that is called when an object of a class is created. It is used to initialize the object's properties.
Circle class example
المنشئ (Constructor) هو طريقة خاصة يتم استدعاؤها عند إنشاء كائن من فئة معينة. يتم استخدامه لتهيئة خصائص الكائن.
مثال على كلاس دائرة

First using default contructor
في حال استخدام المُنشئ الافتراضي
```csharp
Circle defaultCircle = new Circle();
Console.WriteLine($"Default Circle Area: {defaultCircle.Area()}"); // Radius is 0, so area is 0
```
Then using parameterized constructor
باستخدام المُنشئ المُعطى بالمعاملات
```csharp
Circle circle = new Circle(5);
Console.WriteLine($"Circle Area: {circle.Area()}"); // Area = π * r^2 = π * 5^2 = 78.54
Console.WriteLine($"Circle Circumference: {circle.Circumference()}"); // Circumference = 2 * π * r = 2 * π * 5 = 31.42
                                                                     //Note: Math.PI is a constant in the Math class that represents the value of π (pi) to a high degree of precision.
```
### Note
- If no constructor is defined, C# provides a default constructor that initializes all fields to their default values.
  But if you define any constructor, the default constructor is not provided automatically, if you want the default one you should write it by yourself.


## Tip 4: Static field vs Const
A **static field** is a variable that is shared among all instances of a class. It can be changed at runtime.
A **const** is a variable whose value cannot be changed after it is initialized. It is implicitly static and must be initialized at the time of declaration.
Example:
```csharp
    internal class ClassA
    {
        public static int StaticProperty { get; set; } = 42;
        public const int StaticProperty2 = 43;
        public ClassA() { }

    }

//Program.cs
    class Program
    {
        static void Main(string[] args)
        {
            // Accessing static field
            Console.WriteLine($"Static Property: {ClassA.StaticProperty}"); // Output: 42
            // Modifying static field
            ClassA.StaticProperty = 100;
            Console.WriteLine($"Modified Static Property: {ClassA.StaticProperty}"); // Output: 100
            // Accessing const field
            Console.WriteLine($"Const Property: {ClassA.StaticProperty2}"); // Output: 43
            // Attempting to modify const field (uncommenting the next line will cause a compile-time error)
            // ClassA.StaticProperty2 = 200; // Error: The left-hand side of an assignment must be a variable, property or indexer
        }
    }
```
## Tip 5: Using Static Statements
The `using static` directive allows you to import static members of a class so that you can use them without qualifying them with the class name.
Example:
```csharp
using System;
using static System.Math; // Importing static members of the Math class
class Program
{
    static void Main(string[] args)
    {
        double radius = 5.0;
        double area = PI * Pow(radius, 2); // Using PI and Pow without Math. prefix
        Console.WriteLine($"Area of circle with radius {radius} is {area}");
    }
}
```
## Tip 6: Destructor vs Deconstructer
A **destructor** is a special method that is called when an object is about to be destroyed. It is used to clean up resources that the object may be holding, but rerely used because the Garbage Collector automatically handle the memory.
A **deconstructor** is a method that allows you to decompose an object into its constituent (المكوّن) parts. It is often used in conjunction with tuples and pattern matching.
Example:
```csharp
public class Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    // Deconstructor
    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
    // Destructor (not commonly used in C#) or finalizer
    ~Point()
    {
        // Cleanup code here (if needed)
        Console.WriteLine("Point object is being destroyed");
    }
}
// Usage
class Program
{
    static void Main(string[] args)
    {
        Point point = new Point(10, 20);
        // Using deconstructor
        var (x, y) = point;
        Console.WriteLine($"Point coordinates: X = {x}, Y = {y}");
    }
}
```
- Finalizers (destructors) are not commonly used in C# because the garbage collector automatically handles memory management. However, they can be useful for cleaning up unmanaged resources, such as file handles or database connections, that the garbage collector does not manage.
  The compiler translates destructors into overrides of the `Object.Finalize` method. When a destructor is defined, the compiler adds code to ensure that the destructor is called by the garbage collector before the object's memory is reclaimed.
  `~ClassName() { // cleanup code }`
- This will translate to:
  `protected override void Finalize() { try { // cleanup code } finally { base.Finalize(); } }`


## Tip 7: Value vs Reference Type
In C#, types are divided into two categories: **value types** and **reference types**.
- **Value Types**: These types store the actual data in memory blocks. When you assign a value type to another variable, a copy of the value is made.
  for example declaring an int variable causes the
compiler to allocate 4 bytes of memory (32 bits) to hold the integer value. A statement that assigns a
value (such as 42) to the int causes the value to be copied into this block of memory.. Examples include `int`, `float`, `bool`, and `struct`.
- **Reference Types**: These types store a reference (or address) to the actual data. suppose we have an object named "Circle" when we declare that object the compiler does not generate code that allocates a block of memory big enough to
hold a Circle object. All it does is allot a small piece of memory that can potentially hold the address
of (or a reference to) another block of memory containing a Circle object. (An address specifies the
location of an item in memory.) The memory for the actual Circle object is allocated only when the
_**new**_ keyword is used to create the object.. Examples include `class`, `array`, `string`, and `interface`.

## Tip 8: String type is a class
The string type in C# is actually a class. This is because there is no standard size
for a string (different strings can contain different numbers of characters), and allocating
memory for a string dynamically when the program runs is far more efficient than doing so
statically at compile time. The description in this chapter of reference types such as classes
applies to the string type as well. In fact, the string keyword in C# is just an alias for the
System.String class.

## Tip 9: Boxing vs Unboxing
**Boxing** is the process of converting a value type to a reference type by wrapping the value inside an object. 
This allows value types to be treated as objects, Actually there is a place in the HEAP (Piece of Memory) this converted value stored there.
**Unboxing** is the reverse process of extracting the value type from the object.
Example:
```csharp
int value = 42; // Value type
object boxedValue = value; // Boxing: converting value type to reference type
int unboxedValue = (int)boxedValue; // Unboxing: converting reference type back to value type
```

## Tip 10: OOP
- **Encapsulation**: _Reduce Complexity & Increase Reusability_ Bundling data and methods that operate on the data within a single unit or class, restricting access to some components.
- **Abstraction**: _Reduce Complexity & Isolate Impacts of Changes_ Hiding complex implementation details and showing only the necessary parts of an object.
- **Inheritance**: _Eliminate Redundant Code & Improve Code Reusability_ A mechanism where a new class can inherit, لإزالة الإسهاب في الكود
- **Polymorphism**: _Simplify Code & Improve Maintainability & Refactor Ugly switch/case Statements_ The ability of different classes to be treated as instances of the same class through a common interface, allowing methods to operate on objects of different types.

## Tip 11: Interface Implementation Means
When a class implements an interface, it is essentially entering into a contract to provide specific functionality defined by that interface. This means the class must provide concrete implementations for all the methods, properties, and events declared in the interface. By doing so, the class agrees to adhere to the structure and behavior outlined by the interface, ensuring consistency and predictability when interacting with instances of that class through the interface type.
From OOP perspective, implementing an interface allows a class to exhibit polymorphic behavior. This means that objects of the class can be treated **as instances of the interface type**, enabling flexibility and interchangeability in code. It promotes loose coupling, as the code that uses the interface does not need to know the details of the implementing class, only that it adheres to the interface's contract.

## Tip 12: Why we need Garbage Collector
In C#, memory management is handled by the Garbage Collector (GC), which automatically manages the allocation and deallocation of memory for objects. The primary reasons we need a Garbage Collector are:
Example:
```csharp
class Program
{
    static void Main(string[] args)
    {
        // Creating an object of the Circle class
        Circle circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.Area()}");
        // The circle object will be automatically cleaned up by the Garbage Collector when it is no longer needed
    }
}
```
Example of a class that might need cleanup
```csharp
FileProcessor myFp = new FileProcessor();
FileProcessor referenceToMyFp = myFp;
myFp = null; // Now the original FileProcessor object is eligible for garbage collection
```
But !!
If the variable myFp disappears (by going
out of scope), other variables (such as referenceToMyFp) might still exist
So the object is not eligible for garbage collection until all references to it are gone.

```csharp
class FileProcessor
{
    private FileStream fileStream;
    public FileProcessor(string filePath)
    {
        fileStream = new FileStream(filePath, FileMode.Open);
    }
    public void ProcessFile()
    {
        // File processing logic here
    }
    // Destructor (finalizer) to clean up unmanaged resources
    ~FileProcessor()
    {
        if (fileStream != null)
        {
            fileStream.Close();
            fileStream = null;
        }
    }
}
```


The Garbage Collector helps in:
1. **Automatic Memory Management**: It automatically frees up memory occupied by objects that are no longer in use, reducing the risk of memory leaks and other memory-related issues.
2. **Simplified Development**: Developers do not need to manually manage memory allocation and deallocation, allowing them to focus on writing code rather than worrying about memory management.
3. **Improved Performance**: By efficiently managing memory, the Garbage Collector can help improve the overall performance of applications, especially in scenarios with frequent object creation and destruction.
4. **Memory Optimization**: The Garbage Collector can optimize memory usage by compacting memory and reducing fragmentation, leading to better utilization of available memory resources.
5. **Safety**: It helps prevent common memory management errors, such as dangling pointers and double frees, which can lead to application crashes and undefined behavior.
6. **Cross-Platform Consistency**: The Garbage Collector provides a consistent memory management model across different platforms and environments, making it easier to develop cross-platform applications.
7. **Handling Complex Object Graphs**: In applications with complex object relationships, the Garbage Collector can effectively manage memory by tracking object references and ensuring that all unreachable objects are collected.
8. **Support for Modern Programming Paradigms**: The Garbage Collector supports modern programming paradigms, such as functional programming and asynchronous programming, by managing memory in a way that aligns with these paradigms' requirements.

- The garbage collector makes the following guarantees:
  -  Every object will be destroyed. When a program ends, all outstanding objects will be destroyed.
However, any finalizers that haven’t been run by the time the program finishes might not be run at all.
  - Every object will be destroyed at most once.
  - Every object will be destroyed only when it becomes unreachable—that is, when there are no
references to the object in the process running your application.


## Tip 13: Delegates
Store method references in variables __Or__ Store a function within a variable/parameter
- Some Examples:
Storing a method reference in a delegate variable
```csharp
public delegate int MathOperation(int x, int y); // Define a delegate type
class Program
{
    static void Main(string[] args)
    {
        MathOperation add = Add; // Assigning method reference to delegate variable
        MathOperation multiply = Multiply; // Assigning another method reference
        Console.WriteLine($"Addition: {add(5, 3)}"); // Output: 8
        Console.WriteLine($"Multiplication: {multiply(5, 3)}"); // Output: 15
    }
    public static int Add(int x, int y) => x + y; // Method matching the delegate signature
    public static int Multiply(int x, int y) => x * y; // Another method matching the delegate signature
}
```

  


## License
This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
## Contact
For any questions or suggestions, please contact [Asem Alsaiyadi](mailto:asemalsaiyadi@gmail.com).