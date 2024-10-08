using OpenQA.Selenium.Chrome;
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
    public class SkillStepDefinition : CommonDriver
    {
        [Given(@"I logged into the Profile page")]
        public void GivenILoggedIntoTheProfilePage()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When(@"Navigate to the profile")]
        public void WhenNavigateToTheProfile()
        {
            // Profile page object intialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }

        [Then(@"Add the '([^']*)' in skill tab")]
        public void ThenAddTheInSkillTab(string addskill)
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.AddSkill(driver, addskill);
        }


        [Then(@"Update the '([^']*)' in the skill tab")]
        public void ThenUpdateTheInTheSkillTab(string skill)
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.EditSkill(driver, skill);
        }
        [Then(@"Delete the Skill")]
        public void ThenDeleteTheSkill()
        {
            SkillTab skillTabObj = new SkillTab();
            skillTabObj.DeleteSkill(driver);
        }

    }
}
