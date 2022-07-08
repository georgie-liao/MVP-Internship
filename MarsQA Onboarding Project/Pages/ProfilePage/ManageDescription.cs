using MarsQA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_Onboarding_Project.Pages.ProfilePage
{
    public class ManageDescription: CommonDriver
    {
   
        public void AddDescription(IWebDriver driver) // Add description on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 8);

            // Identify Description button and click, and add description 
            IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionButton.Click();

            // Enter desicription
            WaitHelpers.WaiToBeExistent(driver, "Name", "value", 5);
            IWebElement descriptionTextBox = driver.FindElement(By.Name("value"));
            Thread.Sleep(1000);
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("I'm a seller");


            // Idenfity and click on dscription Save button
            IWebElement descriptionSaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            descriptionSaveButton.Click();

        }

        public string GetNewDescriptionAlertMessage(IWebDriver driver) // Get the alaert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newDescriptionAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newDescriptionAlertmMssage.Text;
        }


        public string GetNewDescription(IWebDriver driver) // Get the newly added description
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/span", 8);

            IWebElement newDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return newDescription.Text;
        }

        
        public void EditDescription(IWebDriver driver, string description) // Edit description on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 5);

            // Identify Description button and click, then edit description 
            IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionButton.Click();

            // Enter desicription
            WaitHelpers.WaiToBeExistent(driver, "Name", "value", 5);
            IWebElement descriptionTextBox = driver.FindElement(By.Name("value"));
            Thread.Sleep(1000);
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys(description);


            // Idenfity and click on dscription Save button
            IWebElement descriptionSaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            descriptionSaveButton.Click();

        }

        public string GetEditedDescriptionAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/span", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedDescriptionAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedDescriptionAlertmMssage.Text;
        }

        public string GetEditedDescription(IWebDriver driver) // Get the edited description
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/span", 5);

            IWebElement editedDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return editedDescription.Text;
        }

        
        public void DeleteDescription(IWebDriver driver) // Delete a record of description on profile
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 5);

            // Identify Description button and click, then edit description 
            IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionButton.Click();

            // Clear desicription
            IWebElement descriptionTextBox = driver.FindElement(By.Name("value"));
            Thread.Sleep(1000);
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("N/A");

            // Idenfity and click on dscription Save button
            IWebElement descriptionSaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            descriptionSaveButton.Click();
        }

        public string GetDeletedDescriptionAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement deletedDescriptionAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return deletedDescriptionAlertmMssage.Text;
        }

        public string GetDeletedDescription(IWebDriver driver) // Get the delted description
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/span", 5);

            IWebElement deletedDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return deletedDescription.Text;
        }

    }
}
