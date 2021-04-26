using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using April2021.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace April2021.Steps
{
    [Binding]
    public sealed class LoginpageSteps
    {

        private readonly IWebDriver driver;

        public LoginpageSteps()

        {
            driver = new ChromeDriver();
        }
    


        [Given("I am at the login page")]
        public void GivenIAmAtTheLoginPage()
            
        {

            Loginpage loginPage = new Loginpage();
            loginPage.NavigateToLoginPage(driver);

            Console.WriteLine("I am at the loginpage");
        }


        [Given("I validate that I am at the login page")]
        public void GivenIValidateThatIAmAtTheLoginPage()

        {
            Loginpage loginpage = new Loginpage();
            bool isAtLoginpage=loginpage.ValidateThatYouAreLoginPage(driver);

            Assert.IsTrue(isAtLoginpage);
        }


        [When("I enter valid credentials")]
        public void WhenIenterValidCredentials()
        {
            Loginpage loginpage = new Loginpage();
            loginpage.EnterUsernameAndPassword("");
            loginpage.ValidateThatYouAreLoginPageStaic
            Console.WriteLine("I enter valid creds");
        }


        [When("I click the loginbutton")]
        public void WhenIClickTheLoginbutton()
        {
            Console.WriteLine("I click the loginbutton");
        }


        [Then("I should be logged in successfully")]
        public void ThenIshouldBeLoggedInSuccessfully()
        {
            Console.WriteLine("I should be logged in successfully");
            Assert.IsTrue(false);

        }
     
        [When("When I login with username '(.*)'")]
        public void WhenILoginWithUsername(String username)
        {
            Console.WriteLine("When i Login with user name-" +username);
        }


        [When("When I login with '(.*)' and with (.*)")]
        public void WhenILoginWithUsername(String username, String password)
        {
            Console.WriteLine("I Login with user name-" + username +  password);
        }


        [Then("I should be not logged in")]
        public void ThenIshouldBeNotLoggedIn()
        {
            Console.WriteLine("I should be not logged in");
            Assert.IsTrue(false);

        }

        
    }
}
