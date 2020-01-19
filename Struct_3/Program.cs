using System;

namespace Struct_3
{
    struct MyStruct
    {
        public string change;
    }
    class MyClass
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменен";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменена";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "не изменен";
            myStruct.change = "не изменена";
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine("Структура: {0}\nКласс: {1}", myStruct.change, myClass.change);
            Console.ReadKey();
        }
    }
}
