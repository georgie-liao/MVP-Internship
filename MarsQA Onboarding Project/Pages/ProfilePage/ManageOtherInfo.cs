using MarsQA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_Onboarding_Project.Pages.ProfilePage
{
    public class ManageOtherInfo : CommonDriver
    {
        public void AddOtherInfo(IWebDriver driver) // Add availability, hours and earn target on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 5);

            IWebElement addAvailabilityButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            addAvailabilityButton.Click();

            IWebElement availabilityDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            availabilityDropdown.Click();

            IWebElement chooseAvailability = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
            chooseAvailability.Click();

            IWebElement addHoursButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            addHoursButton.Click();

            IWebElement hoursDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            hoursDropdown.Click();

            IWebElement chooseHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[2]"));
            chooseHours.Click();

            IWebElement addEarnTargetButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            addEarnTargetButton.Click();

            IWebElement earnTargetDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            earnTargetDropdown.Click();

            IWebElement chooseEarnTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[2]"));
            chooseEarnTarget.Click();
        }

        public string GetNewAvailability(IWebDriver driver) // Get the newly added availability
        {
            Thread.Sleep(1000);

            IWebElement newAvailability = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            return newAvailability.Text;
        }

        public string GetNewAvailabilityAlertMessage(IWebDriver driver) // Get the alert message 
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newAvailablityAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newAvailablityAlertmMssage.Text;
        }


        public string GetNewHours(IWebDriver driver) // Get the newly added added hours
        {
            Thread.Sleep(1000);

            IWebElement newHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            return newHours.Text;
        }

        public string GetNewHoursAlertMessage(IWebDriver driver) // Get the alert message 
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newHoursAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newHoursAlertmMssage.Text;
        }

        public string GetNewEanTarget(IWebDriver driver) // Get the newly added earn target
        {
            Thread.Sleep(1000);

            IWebElement newEartTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            return newEartTarget.Text;
        }

        public string GetNewEarnTargetAlertMessage(IWebDriver driver) // Get the alert message 
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newEarnTargetAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newEarnTargetAlertmMssage.Text;
        }

        public void EditOtherInfo(IWebDriver driver) // Edit availability, hours and earn target on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 5);

            IWebElement editAvailabilityButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            editAvailabilityButton.Click();

            IWebElement availabilityDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            availabilityDropdown.Click();

            Thread.Sleep(1000);

            IWebElement chooseAvailability = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
            chooseAvailability.Click();

            IWebElement editHoursButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            editHoursButton.Click();                                   

            IWebElement hoursDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            hoursDropdown.Click();

            IWebElement chooseHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
            chooseHours.Click();

            IWebElement editEarnTargetButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            editEarnTargetButton.Click();

            IWebElement earnTargetDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            earnTargetDropdown.Click();

            IWebElement chooseEarnTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]"));
            chooseEarnTarget.Click();
        }


        public string GetEditedAvailability(IWebDriver driver) // Get the edited availability
        {
            Thread.Sleep(1000);

            IWebElement editedAvailability = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            return editedAvailability.Text;
        }

        public string GetEditedAvailabilityAlertMessage(IWebDriver driver) // Get the alert message 
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedAvailablityAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedAvailablityAlertmMssage.Text;
        }


        public string GetEditedHours(IWebDriver driver) // Get the eidted hours
        {
            Thread.Sleep(1000);

            IWebElement editedHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            return editedHours.Text;
        }

        public string GetEditedHoursAlertMessage(IWebDriver driver) // Get the alert message 
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedHoursAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedHoursAlertmMssage.Text;
        }

        public string GetEditedEanTarget(IWebDriver driver) // Get the edited earn target
        {
            Thread.Sleep(1000);

            IWebElement editedEartTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            return editedEartTarget.Text;
        }

        public string GetEditedEarnTargetAlertMessage(IWebDriver driver) // Get the alert message 
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedEarnTargetAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedEarnTargetAlertmMssage.Text;
        }

    }
}
