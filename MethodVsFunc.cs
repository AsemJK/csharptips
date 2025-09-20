using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptips
{
    internal class MethodVsFunc
    {
        public void Run()
        {
            Func<int, int> func = x => x * x;
            int resultFunc = func(5);
            Console.WriteLine($"Func result: {resultFunc}");
        }
    }
}
