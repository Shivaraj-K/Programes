using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programes.First
{
    public class RemoveMultiplePlace
    {
        public void RmvMulPlc()
        {
            string a = "The   world    become     truely    green  ".Trim();
            string b = "";
            for(int i=0; i<a.Length; i++)
            {
                if (a.Length-1 ==i)
                {
                    b = b + a[i];
                    break;
                }
                else if ( a[i] != ' ')
                {
                    b = b + a[i];
                }
                else if (a[i]==' '&& a[i+1]!=' ')
                {
                    b = b + a[i];
                }
               

            }
            Console.WriteLine(b);

        }
    }
}
