using System;

namespace consoleApp
{
    class BaseClass
    {

        public class InternalClass
        {
            public int Number { get; set; }
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Method1();
            instance.Method2();

            BaseClass.InternalClass intClass = new BaseClass.InternalClass();
            intClass.Number = 5;

            Console.WriteLine(intClass.Number);
        }
    }
}
