using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestS
    {
        public static IList TestData()
        {
            ArrayList a = new ArrayList();
            a.Add("Shivara");
            a.Add("Priya");
            a.Add("Sushma");

            return a;
        }

        public static IEnumerable<string> TestData3()
        {
            yield return "Shivara";
            yield return "Priya";
            yield return "Sushma";
        }

        public static IEnumerable<object[]> TestData4()
        {
            yield return new object[] { 1, "Shivarajendra", "male" };
            yield return new object[] { 2, "Priya S Guttedar", "Female" };
            yield return new object[] { 3, "Sushma", "female" };
        }

        public static void Sc(IWebDriver d)
        {
            ITakesScreenshot t= (ITakesScreenshot)d;

        }
    }
}
