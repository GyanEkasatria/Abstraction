using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class IceBear : IKarakter
    {
        public void AboutK()
        {
            Console.WriteLine("Ice Bear/IceBear : ");
            Console.WriteLine("Adalah beruang kutub dan adik termuda,Ice Bear sering tenang dan jarang berbicara");
            Console.WriteLine("Dia multibahasa,telah terbukti bisa berbicara bahasa Korea, Prancis, Jepang,dan bahasa Rusia dengan lancar.");
        }
    }
}
