using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace TestProject1.TestBased
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver d;
        [SetUp]
        public void TestS1()
        {
            Console.WriteLine("Setup");
        }
        [TearDown]
        public void TestT()
        {

            Console.WriteLine("TearDown");
        }
        [Test,Order(1)]
        public void TestFunc1()
        {
            d = new ChromeDriver();
            d.Manage().Window.Maximize();
            Thread.Sleep(3000);
            d.Url = "https://www.google.com";
            Console.WriteLine("First");
        }

        [Test,Author("Shivaraj"), Category("Reg")]
        public void TestFunc2()
        {
            d = new ChromeDriver();
            d.Manage().Window.Maximize();
            Thread.Sleep(3000);
            d.Url = "https://www.google.com";
            Console.WriteLine("Second");
        }

        [Test, Author("Shivaraj"), Category("Reg")]
        public void TestFunc6()
        {
            d = new ChromeDriver();
            d.Manage().Window.Maximize();
            Thread.Sleep(3000);
            d.Url = "https://www.google.com";
            Console.WriteLine("Second");
        }
        [Test, Author("Shivaraj"), Category("Reg")]
        public void TestFunc7()
        {
            d = new ChromeDriver();
            d.Manage().Window.Maximize();
            Thread.Sleep(3000);
            d.Url = "https://www.google.com";
            Console.WriteLine("Second");
        }

        [Test, Category("Reg")]
        [ Author("Shivaraj")]
        public void TestFunc8()
        {
            d = new ChromeDriver();
            d.Manage().Window.Maximize();
            Thread.Sleep(3000);
            d.Url = "https://www.google.com";
            Console.WriteLine("Second");
        }


        [Test, Author("Shivaraj"), Order(5),Category("Smoke")]
        public void TestFunc3()
        {
            d.Manage().Window.Maximize();
            Thread.Sleep(3000);
            d.Url = "https://www.google.com";
            Console.WriteLine("Third");
        }

        [Test, Author("Shivaraj"), Order(3), Category("Smoke")]
        [TestCaseSource(typeof(TestS), nameof(TestS.TestData4))]
        public void TestFunc4(int a,String c,string b)
        {
             d=new ChromeDriver();
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(b);
        }

        //public static IList TestData()
        //{
        //    ArrayList a=new ArrayList();
        //    a.Add("Shivara");
        //    a.Add("Priya");
        //    a.Add("Sushma");

        //    return a;
        //}
    }
}
