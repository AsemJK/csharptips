# cSharp Tips
This repository contains a collection of tips and tricks for C# programming. Each tip is designed to help you write cleaner, more efficient, and more maintainable code.
## Table of Contents
- [Tip 1: Method vs Function](#tip-1-method-vs-function)
- [Tip 2: Parameter Vs Argument](#tip-2-parameter-vs-argument)



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




## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue if you have any tips to share or improvements to suggest.
## License
This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
## Contact
For any questions or suggestions, please contact [Asem Alsaiyadi](mailto:asemalsaiyadi@gmail.com).