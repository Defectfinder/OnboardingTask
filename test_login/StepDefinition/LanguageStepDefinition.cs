using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.NUnit.SpecFlowPlugin;
using test_login.Pages;
using test_login.Specflow;
using test_login.Utilities;

namespace test_login.StepDefinition
{
    [Binding]
    public class LanguageStepDefinition : CommonDriver
    {
        [Given(@"I logged into the Profile site")]
        public void GivenILoggedIntoTheProfileSite()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When(@"Navigate to the profile tab")]
        public void WhenNavigateToTheProfileTab()
        {
            // Profile page object intialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }

        [When(@"Add the Language in language tab")]
        public void WhenAddTheLanguageInLanguageTab()
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.AddLanguage(driver);
        }

        [When(@"Edited the '(.*)'")]
        public void WhenEditedThe(string language)
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.EditLanguage(driver,language);

        }

        [When(@"Delete the Language")]
        public void WhenDeleteTheLanguage()
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.DeleteLanguage(driver);
        }



        //[Then(@"I should see the Message")]
        //public void ThenIShouldSeeTheMessage(string language)
        //{
        //    LanguageTab langTabObj = new LanguageTab();

        //    string newLanguage = langTabObj.GetLanguage(driver);
        //    string newLanguageLevel = langTabObj.GetLanguageLevel(driver);

        //    Assert.That(newLanguage == language, "Added language is not match");
        //    Assert.That(newLanguageLevel == "Basic", "Added language is not match");
        //}



        [AfterScenario]
        public void TearDown()
        {
           driver.Quit();
        }
    }
}
 











