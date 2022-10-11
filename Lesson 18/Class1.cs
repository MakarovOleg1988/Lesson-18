using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_18
{
    class Class1
    {
        public delegate string ExampleDelegate(int arg1, long arg2);

        public event ExampleDelegate _exampleEventHandler;

        public void CreateBinds()
        {
            _exampleEventHandler += (i, l) =>
            {
                if (i > l)
                {
                    return "Greater";
                }
                else return "Less";

                _exampleEventHandler += Print;
                _exampleEventHandler -= Print;
            };
        }

        public void CreateBinds2()
        {
            var _func = new Func<int, int>((t) =>
            {
                return t * t; 
            });

            var r = _func.Invoke(13);
        
        }

        public string Print(int arg1, long arg2)
        {
            Console.WriteLine("call");
            return string.Empty;
        }

        public string CallBackMethod()
        {
            return _exampleEventHandler?.Invoke(10, 20);
        }
    }
}
