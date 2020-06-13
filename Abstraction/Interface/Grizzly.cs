using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Grizzly : IKarakter
    {
        public void AboutK()
        {
            Console.WriteLine("Grizzly/Grizz  : ");
            Console.WriteLine("Pemimpin tertua dan de facto dari saudaranya, Grizz adalah makhluk yang sangat mencintai dan ramah");
            Console.WriteLine("Grizzly secara paradoks sangat ramah namun tidak kompeten secara sosial.\n");
        }
    }
}
