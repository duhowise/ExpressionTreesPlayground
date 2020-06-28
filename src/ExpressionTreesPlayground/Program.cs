using System;

namespace ExpressionTreesPlayground {
    class Program {
        static void Main (string[] args) {
            Func<MyClass, string> func = c => c.MyMethod (1, "some data");

            Func<int, int, int> sum = (x, y) => x + y;
        }

        private static void AnotherMethod(Func<MyClass, string> someFunc)
        {
            //do something with method
        }
    }
}