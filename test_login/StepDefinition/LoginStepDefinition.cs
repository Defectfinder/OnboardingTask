using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using test_login.Pages;
using test_login.Utilities;

namespace test_login.StepDefinition
{

    [Binding]
    public class LoginStepDefinition : CommonDriver
    {
      

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Then(@"I should be redirected to the homepage")]
        public void ThenIShouldBeRedirectedToTheHomepage()
        {
            // Profile page object intialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }


        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}


