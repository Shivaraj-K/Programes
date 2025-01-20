using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programes.StringProgramss
{
    public class CountTheWord
    {
        public void CountTheWords()
        {
            int c = 1;
            string a = " The world become truely green ";
            a = a.Trim();
            //if (a[0]==' ')
            //{
            //    c = 0;
            //}
            //else
            //{
            //    c = 1;
            //}
            for (int i = 0; i < a.Length; i++)
            {

                //if(i==a.Length-1)
                //{
                //    break;
                //}
                if (a[i] == ' ' && a[i + 1] != ' ')
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
