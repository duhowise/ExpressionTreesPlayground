using System;
using System.Linq.Expressions;

namespace ExpressionTreesPlayground {
    class Program {
        static void Main (string[] args) {
            Func<MyClass, string> func = c => c.MyMethod (1, "");
            Expression<Func<MyClass, string>> expression = c => c.MyMethod (1, "");
        }
    }
}