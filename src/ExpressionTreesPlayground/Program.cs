using System;
using System.Linq.Expressions;
using System.Reflection;

namespace ExpressionTreesPlayground {
    class Program {
        static void Main (string[] args) {
            Func<MyClass, string> func = c => c.MyMethod (1, "some data");
          //Dispatch func execution to another method
            AnotherMethod(func);
           var stringOutput= func(new MyClass());
        }

        private static void AnotherMethod(Func<MyClass, string> someFunc)
        {
            //do something with method
        }
    }
}