using April2021.Page;
using April2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace April2021
{     
    [TestFixture]
    [Parallelizable]
    class Loginuser:CommonDriver
    {

        //static void Main(string[] args) 
        //{
        //}




        [Test]
        public void CreateTMTest()
        {

            //page objects for homepage
            Homepage homeobj = new Homepage();
            homeobj.NavigateToTM(driver);

            //page objects for TMPage
            TMPage tmobj = new TMPage();
            tmobj.CreateTM(driver);




        }

        [Test]
        public void EditTMTest()
        {
            //page objects for homepage
            Homepage homeobj = new Homepage();
            homeobj.NavigateToTM(driver);

            //page objects for TMPage
            TMPage tmobj = new TMPage();
            tmobj.CreateTM(driver);
            tmobj.EditTM(driver);
            

        }

        [Test]
        public void DeleteTMTest()
        {
            //page objects for homepage
            Homepage homeobj = new Homepage();
            homeobj.NavigateToTM(driver);

            //page objects for TMPage
            TMPage tmobj = new TMPage();
            tmobj.DeleteTM(driver);


        }
        
    }

}





