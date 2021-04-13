using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace April2021.Page
{
    class Homepage
    {
        public void navigateToTM(IWebDriver driver)
        {
            //click admin
            IWebElement Adminstration = driver.FindElement(By.XPath("html/body/div[3]/div/div/ul/li[5]/a"));
            Adminstration.Click();

            Thread.Sleep(500);

            //click Time and Materials
            IWebElement Timeandmaterials = driver.FindElement(By.XPath("html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            Timeandmaterials.Click();

        }
    }
}
