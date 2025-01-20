using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programes
{
    internal interface Interface1
    {
        static int s = 3;
        void bike(int x);

    }

    class tt : Interface1
    {
        public int b = 5;
        public void bike(int x)
        {
            Console.WriteLine(x);
        }
    }

    //class mim
    //{
    //    public static void Main(string[] args)
    //{
    //        Interface1 i = new tt();
    //        Interface1.s = 2;
    //        Console.WriteLine(Interface1.s);
    //        tt t = (tt) i;
    //        Console.WriteLine(t.b);
    //        i.bike(1);


    //}
    //}}

}
