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
    public class ManageCertification: CommonDriver
    {
        public void AddCertification(IWebDriver driver) // Add a new certification on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);

            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            IWebElement certificationAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            certificationAddNewButton.Click();

            IWebElement CertificationTextBox = driver.FindElement(By.Name("certificationName"));
            CertificationTextBox.SendKeys("Postgraduate diplomas");

            IWebElement CertificationFromTextBox = driver.FindElement(By.Name("certificationFrom"));
            CertificationFromTextBox.SendKeys("Auckland University");

            var selectYearOfCertification = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
            selectYearOfCertification.SelectByValue("2008");

            IWebElement addCertificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addCertificationButton.Click();
        }

        public string GetNewCertificationAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newCertificationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newCertificationAlertmMssage.Text;
        }

        public string GetNewCertification(IWebDriver driver) // Get newly added certification
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 5);
            IWebElement newCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newCertification.Text;
        }

        public string GetNewCertificationFrom(IWebDriver driver) // Get newly added certification from 
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]", 5);
            IWebElement newCertificationFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newCertificationFrom.Text;
        }

        public string GetNewCertificationYear(IWebDriver driver) // // Get newly added year of certification 
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]", 5);
            IWebElement newCertificationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return newCertificationYear.Text;
        }

        public void EditCertification(IWebDriver driver, string certificate, string certificateFrom, string certificateYear) // Edit an existing certification on profile
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);

            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            IWebElement certificationEditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
            certificationEditButton.Click();

            WaitHelpers.WaitToBeVisible(driver, "Name", "certificationName", 5);

            IWebElement editcertificationTextBox = driver.FindElement(By.Name("certificationName"));
            editcertificationTextBox.Clear();
            editcertificationTextBox.SendKeys(certificate);

            IWebElement CertificationFromTextBox = driver.FindElement(By.Name("certificationFrom"));
            CertificationFromTextBox.Clear();
            CertificationFromTextBox.SendKeys(certificateFrom);

            var selectYearOfCertification = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[3]/select")));
            selectYearOfCertification.SelectByValue(certificateYear);

            IWebElement certificationUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            certificationUpdateButton.Click();
        }

        public string GetEditedCertificationAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedCertificationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedCertificationAlertmMssage.Text;
        }

        public string GetEditedCertification(IWebDriver driver) // Get newly edited certification
        {
            Thread.Sleep(1000);
            IWebElement editedCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedCertification.Text;
        }

        public string GetEditedCertificationFrom(IWebDriver driver) // Get newly edited certification from
        {
            Thread.Sleep(1000);
            IWebElement editedCertificationFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedCertificationFrom.Text;
        }

        public string GetEditedCertificationYear(IWebDriver driver) // Get newly edited year of certification
        {
            Thread.Sleep(1000);
            IWebElement editedCertificationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return editedCertificationYear.Text;
        }


        public void DeleteCertification(IWebDriver driver)  // Delete a record of certification
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);

            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            IWebElement deleteCertificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
            deleteCertificationButton.Click();
        }

        public string GetdeletedCertification(IWebDriver driver) // Get deleted certification
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table[last()]/tbody[2]/tr/td[1]", 5);
            IWebElement deletedCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table[last()]/tbody[2]/tr/td[1]"));
            return deletedCertification.Text;
        }

        public string GetCertificationDeleteAlertMessage(IWebDriver driver) // Get the alert message
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement certificationDeleteAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return certificationDeleteAlertmMssage.Text;
        }
    }
}
