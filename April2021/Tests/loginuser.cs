using April2021.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace April2021
{
    class loginuser
    {
        static void Main(string[] args)
        {


            Console.WriteLine("helloworld");
            // launch turnup portal

            IWebDriver driver = new ChromeDriver();

            //page objects for login
            Loginpage loginobj = new Loginpage();
            loginobj.loginsteps(driver);

            //page objects for homepage
            Homepage homeobj = new Homepage();
            homeobj.navigateToTM(driver);

            //page objects for TMPage
            TMPage tmobj = new TMPage();
            tmobj.createTM(driver);
            tmobj.editTM(driver);
            tmobj.deleteTM(driver);

            //close driver
            driver.Close();



        }
    }
}





