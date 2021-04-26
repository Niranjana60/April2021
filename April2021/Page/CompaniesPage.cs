using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace April2021.Page
{
    class CompaniesPage
    {

        public void Createcompany(IWebDriver driver)
        {
            //script to validate create company
            IWebElement createnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnew.Click();
            //expect delay
            Thread.Sleep(1000);

           IWebElement Name = driver.FindElement(By.XPath(".//*[@id='Name']"));
            Name.SendKeys("POP");
            IWebElement editcontact =driver.FindElement(By.XPath("//*[@id='EditContactButton']"));
            editcontact.Click();
           // editcontact.SendKeys("3456");

        }

        public void Editcompany(IWebDriver driver)
        {
            //script to validate edit company
        }

        public void Deletecompany(IWebDriver driver)
        {
            //script to validate delete company-ignore
        }

    }
}
