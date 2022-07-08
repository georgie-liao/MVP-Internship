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
    public class ManageEducation: CommonDriver
    {
        public void AddEducation(IWebDriver driver) // Add a new skill on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);

            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            IWebElement educationAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationAddNewButton.Click();

            IWebElement universityTextBox = driver.FindElement(By.Name("instituteName"));
            universityTextBox.SendKeys("Auckland University");

            IWebElement countryOfUniversityDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryOfUniversityDropdown.Click();

            IWebElement chooseCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            chooseCountryOfUniversity.Click();

            IWebElement titleDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();

            IWebElement chooseTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[10]"));
            chooseTitle.Click();

            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.SendKeys("Master");

            IWebElement yearOfGraducationDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearOfGraducationDropdown.Click();

            IWebElement chooseYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[6]"));
            chooseYearOfGraducation.Click();

            IWebElement educationAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            educationAddButton.Click();
        }

        public string GetNewEducationAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newEducationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newEducationAlertmMssage.Text;
        }

        public string GetNewUniversity(IWebDriver driver) // The newly added university
        {
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();
            
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[2]", 5);

            IWebElement newUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[2]"));
            return newUniversity.Text;
        }

        public string GetNewCountryOfUniversity(IWebDriver driver) // The newly added country of university
        {

            IWebElement newCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[1]"));
            return newCountryOfUniversity.Text;
        }

        public string GetNewTitle(IWebDriver driver) // The newly added title
        {

            IWebElement newTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[3]"));
            return newTitle.Text;
        }

        public string GetNewDegree(IWebDriver driver) // The newly added degree
        {

            IWebElement newDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[4]"));
            return newDegree.Text;
        }

        public string GetNewYearOfGraducation(IWebDriver driver) // The newly added year of graduation
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[5]", 5);

            IWebElement newYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[5]"));
            return newYearOfGraducation.Text;
        }

        public void EditEducation(IWebDriver driver, string country, string unviversity, string title, string degree, string graduationYear) // Edit a record of education
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);

            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            IWebElement editEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i"));
            editEducationButton.Click();

            IWebElement editUniversityTextBox = driver.FindElement(By.Name("instituteName"));
            editUniversityTextBox.Clear();
            editUniversityTextBox.SendKeys(unviversity);

            var selectCountryOfUniversity = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td/div[1]/div[2]/select")));
            selectCountryOfUniversity.SelectByValue(country);

            var selectTitle = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[last()]//div[2]/div[1]/select")));
            selectTitle.SelectByValue(title);

            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.Clear();
            degreeTextBox.SendKeys(degree);

            var selectYearOfGraducation = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td/div[2]/div[3]/select")));
            selectYearOfGraducation.SelectByValue(graduationYear);

            IWebElement educationUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[last()]//div[3]/input[1]"));
            educationUpdateButton.Click();
        }

        public string GetEditedEducationAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedEducationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedEducationAlertmMssage.Text;
        }

        public string GetEditedCountryOfUniversity(IWebDriver driver) // Get the edited country of university
        {
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[1]", 8);

            IWebElement editedCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[1]"));
            return editedCountryOfUniversity.Text;
        }

        public string GetEditedUniversity(IWebDriver driver) // Get the edited university
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[2]", 8);

            IWebElement editedUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[2]"));
            return editedUniversity.Text;
        }

        public string GetEditedYearOfGraducation(IWebDriver driver) // Get edited year of graduation
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[5]", 8);

            IWebElement editedYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[5]"));
            return editedYearOfGraducation.Text;
        }

        public string GetEditedTitle(IWebDriver driver) // Get edited Title
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[3]", 8);

            IWebElement editedTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[3]"));
            return editedTitle.Text;
        }

        public string GetEditedDegree(IWebDriver driver) // Get edited degree
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[4]", 8);

            IWebElement editedDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[4]"));
            return editedDegree.Text;
        }

        public void DeleteEducation(IWebDriver driver)  // Delte an existing education record
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);

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

        public string GetdeletedEducation(IWebDriver driver) // Get the deleted education
        {

            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[2]", 8);

            IWebElement deletedEducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[2]"));
            return deletedEducation.Text;
        }
    }
}
