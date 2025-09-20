# cSharp Tips
This repository contains a collection of tips and tricks for C# programming. Each tip is designed to help you write cleaner, more efficient, and more maintainable code.
## Table of Contents
- [Tip 1: Method vs Function](#tip-1-method-vs-function)
- [Tip 2: Parameter Vs Argument](#tip-2-parameter-vs-argument)
- [Tip 3: Constructors] (#tip-3-constructors)



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
الحجة (Argument) هي القيمة الفعلية التي يتم تمريرها إلى الدالة أو الطريقة عند استدعائها.


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


## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue if you have any tips to share or improvements to suggest.
## License
This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
## Contact
For any questions or suggestions, please contact [Asem Alsaiyadi](mailto:asemalsaiyadi@gmail.com).