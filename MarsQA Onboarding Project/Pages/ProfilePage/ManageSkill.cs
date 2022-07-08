using MarsQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_Onboarding_Project.Pages.ProfilePage
{
    public class ManageSkill : CommonDriver
    {
        public void AddSkill(IWebDriver driver) // Add new skill on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();

            IWebElement skillAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            skillAddNewButton.Click();

            IWebElement addLanguageTextBox = driver.FindElement(By.Name("name"));
            addLanguageTextBox.SendKeys("Customer service skill");

            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdown.Click();

            IWebElement chooseSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            chooseSkillLevel.Click();

            IWebElement skillAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            skillAddButton.Click();
        }

        public string GetNewSkillAlertMessage(IWebDriver driver)  // Get the new skill added alert message 
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newSkillAlertmessage = driver.FindElement(By.XPath(alertMessageXPath));
            return newSkillAlertmessage.Text;
        }

        public string GetNewSkill(IWebDriver driver) // Get the newly added skill
        {
            Thread.Sleep(1000);


            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();

            IWebElement newSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newSkill.Text;

        }

        public string GetNewSkillLevel(IWebDriver driver) // Get the newly added skill level
        {
            Thread.Sleep(1000);

            IWebElement newSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newSkillLevel.Text;
        }


        public void EditSkill(IWebDriver driver, string skill, string level) // Edit an existing Skill record
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();


            IWebElement skillEditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            skillEditButton.Click();

            Thread.Sleep(1000);

            IWebElement skillTextBox = driver.FindElement(By.Name("name"));
            skillTextBox.Clear();
            skillTextBox.SendKeys(skill);

            var selectSkillLevel = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")));
            selectSkillLevel.SelectByValue(level);

            IWebElement skillUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            skillUpdateButton.Click();
        }

        public string GeteditedSkillAlertMessage(IWebDriver driver)  // Get the edited skill alert message 
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedSkillAlertmessage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedSkillAlertmessage.Text;
        }

        public string GetEditedSkill(IWebDriver driver) // Get edited skill
        {
            Thread.Sleep(1000);

            IWebElement editedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedSkill.Text;
        }
        public string GetEditedSkillLevel(IWebDriver driver)
        {

            Thread.Sleep(1000);

            IWebElement editedSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedSkillLevel.Text;
        }

        
        public void DeleteSkill(IWebDriver driver) // Delete a record of skill
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();


            IWebElement deleteSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            deleteSkillButton.Click();
        }

        public string GetSkillDeleteAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement skillDeleteAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return skillDeleteAlertmMssage.Text;
        }

        public string GetdeletedSkill(IWebDriver driver) // Get the deleted skill
        {
            Thread.Sleep(1000);

            IWebElement deletedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedSkill.Text;
        }


        public string GetEditedTitle(IWebDriver driver) // Get edited title
        {

            IWebElement editedTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[3]"));
            return editedTitle.Text;
        }

        public string GetEditedDegree(IWebDriver driver) // Get edited degree
        {

            IWebElement editedDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[4]"));
            return editedDegree.Text;
        }

        public string GetEditedYearOfGraducation(IWebDriver driver) // Get edite year of graduation
        {
            Thread.Sleep(1000);

            IWebElement editedYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[5]"));
            return editedYearOfGraducation.Text;
        }


        public void DeleteEducation(IWebDriver driver)  // Delte an existing education record
        {
            Thread.Sleep(1000);

            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            IWebElement deleteEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i"));
            deleteEducationButton.Click();
        }

        public string GetEducationDeleteAlertMessage(IWebDriver driver) // Get the alert message 
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement educationDeleteAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return educationDeleteAlertmMssage.Text;
        }

        public string GetdeletedEducation(IWebDriver driver) //  Get the deleted education
        {
            Thread.Sleep(1000);

            IWebElement deletedEducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[2]"));
            return deletedEducation.Text;
        }

    }
}
