using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_login.Pages
{
    public class SkillTab
    {
        public void AddSkill(IWebDriver driver, string addskill)
        {
            IWebElement selectSkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            selectSkillTab.Click();
            Thread.Sleep(3000);

            IWebElement addNewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkill.Click();

            IWebElement skillTexbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTexbox.SendKeys(addskill);

            IWebElement selectSkillDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            selectSkillDropdown.Click();

            IWebElement optionSkillSelect = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            optionSkillSelect.Click();

            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillButton.Click();
        }

        public void EditSkill(IWebDriver driver, string skill)
        {
            IWebElement selectSkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            selectSkillTab.Click();
            Thread.Sleep(3000);

            //IWebElement selectEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
            IWebElement selectEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            selectEditButton.Click();
            Thread.Sleep(2000);

            IWebElement editSkillTexbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            editSkillTexbox.Clear();
            editSkillTexbox.SendKeys(skill);

            IWebElement editSkillDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
            editSkillDropdown.Click();
            Thread.Sleep(5000);

            IWebElement dropdownValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[2]"));
            dropdownValue.Click();

            IWebElement selectUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            selectUpdateButton.Click();

        }
        public void DeleteSkill(IWebDriver driver) 
        {
            IWebElement selectSkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            selectSkillTab.Click();
            Thread.Sleep(3000);

            IWebElement deleteSkillIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            deleteSkillIcon.Click();
        }
    }
}
