namespace csharptips.DataTypes
{
    public class Types
    {
        public static void Run()
        {
            var v = Convert.ToInt16("111111111111111", 2);
            Console.WriteLine("First example " + v.ToString());
            Console.WriteLine("***** Data Types *****");
            Console.WriteLine();
            // Value types
            int myInt = 42;
            double myDouble = 3.14;
            bool myBool = true;
            char myChar = 'A';
            Console.WriteLine($"Value Types: int={myInt}, double={myDouble}, bool={myBool}, char={myChar}");
            // Reference types
            string myString = "Hello, World!";
            object myObject = new object();
            Console.WriteLine($"Reference Types: string={myString}, object={myObject}");
            // Nullable types
            int? myNullableInt = null;
            Console.WriteLine($"Nullable Type: int?={myNullableInt}");
            // Implicitly typed variables
            var myVar = 100;
            Console.WriteLine($"Implicitly Typed Variable: var={myVar}");
            // Dynamic type
            dynamic myDynamic = "I am dynamic";
            Console.WriteLine($"Dynamic Type: dynamic={myDynamic}");
            Console.WriteLine();
        }
    }
}
