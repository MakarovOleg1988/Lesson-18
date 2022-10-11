using System;

namespace Lesson_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Class1();

            Console.WriteLine(r.CallBackMethod());
            r.CreateBinds();
            Console.WriteLine(r.CallBackMethod());
        }
    }
}
