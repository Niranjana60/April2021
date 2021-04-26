using April2021.Page;
using April2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace April2021.Tests
{
    [TestFixture]
    [Parallelizable]
    class Companiestest : CommonDriver
    {




        [Test]
        public void CreateCompanyTest()
        {

            //page objects for homepage
            Homepage homeobj = new Homepage();
            homeobj.NavigateToCompanies(driver);

            //page objects for CompanyPage
            CompaniesPage companyobj = new CompaniesPage();
            companyobj.Createcompany(driver);




        }

        [Test]
        public void EditCompanyTest()
        {
            //page objects for homepage
            Homepage homeobj = new Homepage();
            homeobj.NavigateToCompanies(driver);

            //page objects for TMPage
            CompaniesPage companyobj = new CompaniesPage();
            // companyobj.createcompany(driver);
            companyobj.Editcompany(driver);


        }

        [Test]
        public void DeleteCompanyTest()
        {
            //page objects for homepage
            Homepage homeobj = new Homepage();
            homeobj.NavigateToTM(driver);

            //page objects for TMPage
            CompaniesPage companyobj = new CompaniesPage();
            // companyobj.createcompany(driver);
            companyobj.Deletecompany(driver);



        }
        
    }


}









