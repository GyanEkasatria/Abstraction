using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Abstaction
{
    public class Panda : Karakter
    {
        public override void AboutK()
        {
            Console.WriteLine("Panda : ");
            Console.WriteLine("Dia adalah saudara tengah,Dia lembut hati dan merasa malu atau cemas dengan mudah");
            Console.WriteLine("Panda memiliki kepercayaan diri yang jauh lebih sedikit dibanding saudaranya,meski demikian ia pandai dalam menggunakan teknologi.\n");
        }
    }
}
