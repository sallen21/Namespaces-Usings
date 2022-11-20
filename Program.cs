using System;

using namespace1 = myNamespace.AnotherProgram;

using namespace2 = myEarthNamespace.NewAnotherProgram;

namespace newNamespace 
{
   class Program 
   {
       static void Main()
       {
        Console.WriteLine("Hello, World!"); 
        namespace1.printText();
        namespace2.newPrintText();
       }
   }
}
 
  


