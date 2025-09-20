using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptips
{
    internal class ClassB
    {
        private static int _counter = 0;

        public ClassB()
        {
            _counter++;
        }
        public ClassB(int x,int y)
        {
            _counter++;
        }

        public static int GetInstanceCount()
        {
            return _counter;
        }
    }
}
