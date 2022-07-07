using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // Maximize Chrome browser
            driver.Manage().Window.Maximize();

            // Lauch turn up portal 
            driver.Navigate().GoToUrl("http://localhost:5000/");

            try
            {
                // Identify Sign in button and click
                IWebElement signinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signinButton.Click();

                // Switch to the pop up window
                driver.SwitchTo().Window(driver.WindowHandles.Last());

                // Identify username textbox and valid enter username
                IWebElement usernameTextbox = driver.FindElement(By.Name("email"));
                usernameTextbox.SendKeys("georgie.liao@outlook.com");

                // Identify password textbox and valid enter password
                IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
                passwordTextbox.SendKeys("Qqnbbn00");

                // Identify log in button and click                     
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();


            }
            catch (Exception ex)
            {
                Assert.Fail("Login failed.", ex.Message);
            }

            

        }
    }
}
