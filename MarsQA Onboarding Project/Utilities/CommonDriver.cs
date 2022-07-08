
using MarsQA.Pages;
using MarsQA_Onboarding_Project.Pages.ProfilePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        LoginPage loginpageObj = new LoginPage();

        [OneTimeSetUp]
        public void LoginActions()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            // Login page object initialization and definition 
            loginpageObj.LoginSteps(driver);

        }


        [OneTimeTearDown]
        public void CloseTestRun()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            driver.Quit();
        }
    }
}