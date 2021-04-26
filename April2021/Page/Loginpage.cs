using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace April2021.Page
{
    class Loginpage
    {

        public void Loginsteps(IWebDriver driver)
        {
            //1
            // driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            // driver.Manage().Window.Maximize();

            try
            {

                {

                    //identify and enter user name

                    IWebElement username = driver.FindElement(By.Id("UserName"));
                    username.SendKeys("hari");

                    //identify and enter password
                    IWebElement Password = driver.FindElement(By.Id("Password"));
                    Password.SendKeys("123123");

                    //identify and click loginbutton
                    IWebElement loginbutton = driver.FindElement(By.XPath("//input[@value='Log in']"));
                    loginbutton.Click();
                }
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at login page", msg.Message);
            }



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

        private static void EnterUsernameAndPassword(IWebDriver driver)
        {
            try
            {

                {

                    //identify and enter user name

                    IWebElement username = driver.FindElement(By.Id("UserName"));
                    username.SendKeys("hari");

                    //identify and enter password
                    IWebElement Password = driver.FindElement(By.Id("Password"));
                    Password.SendKeys("123123");

                    //identify and click loginbutton
                   // IWebElement loginbutton = driver.FindElement(By.XPath("//input[@value='Log in']"));
                   // loginbutton.Click();
                }
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at login page", msg.Message);
            }
        }

        public void NavigateToLoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
        }


        public bool  ValidateThatYouAreLoginPage(IWebDriver driver)
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//input[@value='Log in']"));
            return loginbutton.Displayed;

        }



        public static bool ValidateThatYouAreLoginPageStatic(IWebDriver driver)
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//input[@value='Log in']"));
            return loginbutton.Displayed;

        }
    }
}
