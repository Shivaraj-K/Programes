
using Programes.StringProgramss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programes.First
{
    internal class StringProgram
    {
        static void Main(string[] args)
        {
            //CountTheWord c=new CountTheWord();
            //c.CountTheWords();

            //ReverseThechar r=new ReverseThechar();
            //// r.ReverseChar();
            ////r.ReverseWord();
            //r.ReverseCharWithoutRevWords();

            RemoveMultiplePlace r = new RemoveMultiplePlace();
            r.RmvMulPlc();
        }

    }
}
