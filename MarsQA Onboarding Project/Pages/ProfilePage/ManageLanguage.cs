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
    public class ManageLanguage : CommonDriver
    {
        public void AddLanguage(IWebDriver driver) // Add languge to profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);

            IWebElement languageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
                        languageButton.Click();

            IWebElement languageAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
                        languageAddNewButton.Click();

            IWebElement addLanguageTextBox = driver.FindElement(By.Name("name"));
                        addLanguageTextBox.SendKeys("English");

            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
                        languageLevelDropdown.Click();

            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
                        chooseLanguageLevel.Click();

            IWebElement languageAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
                        languageAddButton.Click();

        }


        public string GetnewLanguageAlertMessage(IWebDriver driver) // Get the pop-up alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newLanguageAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newLanguageAlertmMssage.Text;
        }


        public string GetNewLanguage(IWebDriver driver)   // Get the newly added language
        {
            Thread.Sleep(1000);

            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
                 return newLanguage.Text;

        }


        public string GetNewLanguageLevel(IWebDriver driver) // Get the newly added language level
        {
            IWebElement newLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
                 return newLanguageLevel.Text;
        }


        public void EditLanguage(IWebDriver driver, string language, string level) // Edit the record of the existing Languages
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);

            IWebElement languageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageButton.Click();

            IWebElement languageEditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            languageEditButton.Click();

            Thread.Sleep(1000);

            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
            languageTextBox.Clear();
            languageTextBox.SendKeys(language);

            var selectLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")));
            selectLanguageLevel.SelectByValue(level);


            IWebElement languageUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            languageUpdateButton.Click();
        }

        public string GeteditedLanguageAlertMessage(IWebDriver driver) // Get the pop-up alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedLanguageAlertmMessage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedLanguageAlertmMessage.Text;
        }


        public string GetEditedLanguage(IWebDriver driver)     // Get edited language
        {
            Thread.Sleep(1000);

            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedLanguage.Text;

        }

        public string GetEditedLanguageLevel(IWebDriver driver) // Get edited language level
        {
            Thread.Sleep(1000);

            IWebElement editedLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedLanguageLevel.Text;
        }

        public void DeleteLanguage(IWebDriver driver) // Delete the last record of existing languages
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 10);

            IWebElement deleteLanguageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteLanguageButton.Click();
        }

        public string GetDeletedLanguageAlertMessage(IWebDriver driver)  // Get the alert message 
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement deletedLaguageAlertmessage = driver.FindElement(By.XPath(alertMessageXPath));
            return deletedLaguageAlertmessage.Text;
        }

        public string GetdeletedLanugage(IWebDriver driver) // check the last record of language for assert
        {

            Thread.Sleep(1000);

            IWebElement deletedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedLanguage.Text;
        }
    
    }
}
