using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programes.StringProgramss
{
    public class ReverseThechar
    {
        public void ReverseChar()
        {
            string a = " The world become truely green ";
            a = a.Trim();

            //for(int i=a.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(a[i]);
//Console.WriteLine("Changed in hh github");
            //}

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i]!=' ')
                {
                    Console.Write(a[i]);
                }
                
            }
        }

        public void ReverseWord()
        {
            string a = "The world become truely green ";
            a = a.Trim();
            string b="",c=""; 
            for (int i=0;i<a.Length;i++)
            {
                if (a[i]!= ' ')
                {
                    b = b + a[i];
                    if(i==a.Length-1)
                    {
                        c = b + " " + c;
                    }
                }
                else if(a[i]==' ')
                {
                    c = b+" "+c;
                    b = "";
                }

            }
            Console.WriteLine(c);
        }

        public void ReverseCharWithoutRevWords()
        {
            string a = "The world become truely green ".Trim();
            string b = "",c="";
            for(int i=0;i<a.Length;i++)
            {

                if (a[i]!=' ')
                {
                    b = a[i]+b;
                    if(i==a.Length-1)
                    {
                        c= c + " " + b;
                    }
                }
                else if (a[i]==' ')
                {
                    c=c+" "+b;
                    b = "";
                }
            }
            Console.WriteLine(c);
        }
    }
}
