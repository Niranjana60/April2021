using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace April2021.Page
{
    class Loginpage
    {

        public void loginsteps(IWebDriver driver)
        {
           
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();


            //identify and enter user name

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //identify and enter password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //identify and click loginbutton
            IWebElement loginbutton = driver.FindElement(By.XPath("//input[@value='Log in']"));
            loginbutton.Click();

            //validate if the user is logged in successfully
            IWebElement hellohari = driver.FindElement(By.XPath("//a[normalize-space()='Hello hari!']"));

            if (hellohari.Text == "Hello hari!")

            {
                Console.WriteLine("Logged in successfully,test passed");
            }

            else
            {
                Console.WriteLine("Logged in failed,test failed");

            }
        }
    }
}
