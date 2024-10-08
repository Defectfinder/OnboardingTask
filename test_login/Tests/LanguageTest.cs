using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_login.Pages;
using test_login.Utilities;

namespace test_login.Tests
{
    [TestFixture]
    public class LanguageTest : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {

            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // Profile page object intialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }
        [Test]
        public void AddLanguage_Test()
        {
            // LanguageTab object initalization and definition
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.AddLanguage(driver);

        }
        [Test]
        public void EditLanguage_Test(string language) 
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.EditLanguage(driver,language);
        }
        [Test]
        public void DeleteLanguage_Test() 
        {
            LanguageTab langTabObj = new LanguageTab();
            langTabObj.DeleteLanguage(driver);
        }
        [Test]
        public void AddSkill_Test(string addskill)
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.AddSkill(driver,addskill);
        }
        [Test]
        public void EditSkill_Test(string skill) 
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.EditSkill(driver,skill);
        }
        [Test]
        public void DeleteSkill_Test()
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.DeleteSkill(driver);
        }
       [TearDown]
       public void Close_test() 
       {
            driver.Quit();
        }
    }
}
