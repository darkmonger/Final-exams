using System;
using smartphone_library;

namespace smartphone_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Samsung samsung21 = new Samsung();
            Console.WriteLine(samsung21.start());
            Console.WriteLine(samsung21.GetOS());
            
            
               

            iphone iphone13 = new iphone();
            Console.WriteLine(iphone13.getname());
            Console.WriteLine(iphone13.GetOS());

        }
    }
}
