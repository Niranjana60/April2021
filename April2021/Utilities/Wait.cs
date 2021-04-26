using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace April2021.Utilities
{
    class Wait
    {
        //generic function to wait
        public  void ElementExists(IWebDriver driver,String attributevalue)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributevalue)));
        }
    }
}
