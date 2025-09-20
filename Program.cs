// See https://aka.ms/new-console-template for more information
using csharptips;

Console.WriteLine("Hello, World!");

//Method vs Func example
//Methos is a named block of code that performs a specific task and can be called directly.
//Func is a general term,It historically refers to a standalone routine that performs a specific task.
// examples:
//- delegate that represents a method that takes parameters and returns a value, allowing methods to be passed as arguments or assigned to variables.
//- concept of adding two numbers together called add function.
MethodVsFunc methodVsFunc = new MethodVsFunc();
methodVsFunc.Run();