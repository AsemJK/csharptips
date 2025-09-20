// See https://aka.ms/new-console-template for more information
using csharptips;
using static System.Console;

WriteLine("Hello, World!");

//Method vs Func example
//Methos is a named block of code that performs a specific task and can be called directly.
//Func is a general term,It historically refers to a standalone routine that performs a specific task.
// examples:
//- delegate that represents a method that takes parameters and returns a value, allowing methods to be passed as arguments or assigned to variables.
//- concept of adding two numbers together called add function.
MethodVsFunc methodVsFunc = new MethodVsFunc();
methodVsFunc.Run();

//Circle class example
//First using default constructor
Circle defaultCircle = new Circle();
WriteLine($"Default Circle Area: {defaultCircle.Area()}"); // Radius is 0, so area is 0

Circle circle = new Circle(5);
WriteLine($"Circle Area: {circle.Area()}"); // Area = π * r^2 = π * 5^2 = 78.54
WriteLine($"Circle Circumference: {circle.Circumference()}"); // Circumference = 2 * π * r = 2 * π * 5 = 31.42
                                                                      //Note: Math.PI is a constant in the Math class that represents the value of π (pi) to a high degree of precision.

//Static class example
WriteLine($"Static Property: {ClassA.StaticProperty}");
ClassA.StaticProperty = 100;
WriteLine($"Static Property: {ClassA.StaticProperty}");
WriteLine($"Static Property2: {ClassA.StaticProperty2}"); // Const property cannot be changed
                                                                        //ClassA.StaticProperty2 = 200; // This line would cause a compile-time error because StaticProperty2 is a constant and cannot be changed.
