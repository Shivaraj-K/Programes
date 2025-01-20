using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programes.First
{
    internal class Class9 
    {
        public void yy()
        {
            Console.WriteLine("hhh");
            string a = "the provide";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]==' ')
                {
                    Console.WriteLine("123");
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
        }
        //static void Main(string[] args)
        //{
        //    Program1 p = new Program1();
        //    Class9 c = new Class9();
        //    c.yy();
        //    // p.tt();

        //    Dictionary<int, string> d = new Dictionary<int, string>();
        //    d.Add(1, "Shivaraj");
        //    d.Add(2, "Shweta");
        //    d.Add(3, "Priya");
        //    d.Add(4, "Gunni");
        //    d.Add(5, "Sushma");
        //    d.Add(6, "AmmaA");

        //    Console.WriteLine(d[4]);
        //    Guid g = Guid.NewGuid();
        //    Console.WriteLine(g.ToString());
        //    Console.WriteLine(g.ToString().Replace("-", string.Empty));
        //    Console.WriteLine(g.ToString("N"));
        //    Console.WriteLine(g.ToString("N").Substring(0, 15));
        //    foreach (int k in d.Keys)
        //    {
        //        string v = d[k];
        //        Console.WriteLine(v + " ==== " + k);

        //    }
        //    foreach (KeyValuePair<int, string> k in d)
        //    {
        //        Console.WriteLine(k.Key + " ==== " + k.Value);
        //    }

        //    foreach (var k in d)
        //    {
        //        Console.WriteLine(k.Key + " ==== " + k.Value);
        //    }

        //}
    }
}
