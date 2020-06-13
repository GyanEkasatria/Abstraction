using System;

using Abstraction.Abstaction;  
//using Abstraction.Interface;  

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Karakter karakter; //Abstraction
            //IKarakter karakter; //Interface

            Console.WriteLine("\nWE BARE BEARS");
            Console.WriteLine("-------------\n");
            
            karakter = new Grizzly();
            karakter.AboutK();

            karakter = new Panda();
            karakter.AboutK();

            karakter = new IceBear();
            karakter.AboutK();

            Console.ReadKey();
        }
    }
}
