using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Panda : IKarakter
    {
        public void AboutK()
        {
            Console.WriteLine("Panda/Pan Pan : ");
            Console.WriteLine("Dia adalah saudara tengah,Dia lembut hati dan merasa malu atau cemas dengan mudah");
            Console.WriteLine("Panda memiliki kepercayaan diri yang jauh lebih sedikit dibanding saudaranya,meski demikian ia pandai dalam menggunakan teknologi.\n");

        }
    }
}
