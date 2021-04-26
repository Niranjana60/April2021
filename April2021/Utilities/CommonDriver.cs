using April2021.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace April2021.Utilities
{
    class CommonDriver
    {
        //init driver
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginTM()
        {

            Console.WriteLine("helloworld");
            // launch turnup portal

            driver = new ChromeDriver();

            //page objects for login
            Loginpage loginobj = new Loginpage();
            loginobj.Loginsteps(driver);


        }


        [OneTimeTearDown]
        public void Finalsteps()
        {
            //close driver
            driver.Close();


        }
    }
}
