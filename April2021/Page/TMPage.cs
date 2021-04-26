using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace April2021.Page
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //***create new TM test



          //expect delay

            //Click create new button
            IWebElement Createnew = driver.FindElement(By.XPath(".//*[@id='container']/p/a"));
            Createnew.Click();

            //expect delay
            Thread.Sleep(1000);

            //Click on material and time
            IWebElement material = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            material.Click();

            //select time from drop down
            IWebElement Time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Time.Click();

            Thread.Sleep(1000);



            //input code

            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("spain15");

            //input description

            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("spain15");

            //input price unit

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("128");
            //upload file-to do

            //save file

            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            Thread.Sleep(5000);
            //verify create
            //go to last page

            //click on last page

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(5000);


            //verify if the last row contains the record created


            IWebElement actualdescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            //option 1
            Assert.That(actualdescription.Text, Is.EqualTo("spain15"),"test failed");


            //option 2

            if (actualdescription.Text == "spain15")
            {
                //Console.WriteLine("TM created,test passed");
                Assert.Pass("TM created,test passed");
            }
            else
            {
                //Console.WriteLine("TM failed to create");
                Assert.Fail("TM failed,test failed");
            }


            Thread.Sleep(2000);

        }

     

        public void EditTM(IWebDriver driver)
        {
            //verify whether user is able to edit the record

            //click on edit button

            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbutton.Click();

            //Edit description

            IWebElement description = driver.FindElement(By.XPath("//*[@id='Description']"));
            description.Clear();
            description.SendKeys("spain15 new description");

            //Edit price per unit
            //IWebElement priceperunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //priceperunit.Clear();
            //priceperunit.SendKeys("128");
            //click on save

            IWebElement save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            save.Click();
            Thread.Sleep(5000);


            //Go to the last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(3500);
        }

        public void DeleteTM(IWebDriver driver)
        {
            //verify user is able to delete the record
            //  Delete the record name "spain 15 "from the list

            IWebElement delete_record = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delete_record.Click();

            Thread.Sleep(2500);

            //switch to alert
            IAlert alt = driver.SwitchTo().Alert();
            alt.Accept();
            Thread.Sleep(2000);

            //After delete go to last page to verify if record is deleted

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(5000);

            IWebElement deletedrecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if (deletedrecord.Text != "spain15")
            {
                Console.WriteLine("Record deleted");
            }

            else
            {
                Console.WriteLine("Record failed to delete");
            }


            Thread.Sleep(2000);



        }
    }
}
