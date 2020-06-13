using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Abstaction
{
    public class Grizzly : Karakter
    {
        public override void AboutK()
        {
            Console.WriteLine("Grizzly  : ");
            Console.WriteLine("Pemimpin tertua dan de facto dari saudaranya, Grizz adalah makhluk yang sangat mencintai dan ramah");
            Console.WriteLine("Grizzly secara paradoks sangat ramah namun tidak kompeten secara sosial.\n");
        }
    }
}
