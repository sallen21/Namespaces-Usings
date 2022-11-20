using System;
namespace myNamespace
{
        class AnotherProgram
        {
            public static void printText(){
                Console.WriteLine("Hello Earth!");
            }
        }
}

namespace myEarthNamespace
{
    class NewAnotherProgram
    {
        public static void newPrintText(){
            Console.WriteLine("Hello people of Earth!");
        }
    }
}