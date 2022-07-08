using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class DescriptionStepDefinitions : CommonDriver
    {
        [Given(@"I logged into portal")]
        public void GivenILoggedIntoPortal()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            // Login page object initialization and definition 
            LoginPage loginpageObj = new LoginPage();

            // Login actions
            loginpageObj.LoginSteps(driver);
        }

        [When(@"I add description on profile")]
        public void WhenIAddDescriptionOnProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add description action
            ProfilePageObj.AddDescription(driver);
        }

        [Then(@"The description should be added successfully")]
        public void ThenTheDescriptionShouldBeAddedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the newly added description on profile
            string newDescription = ProfilePageObj.GetNewDescription(driver);
            Assert.That(newDescription == "I'm a seller", "Actual record and expected record do not match.");

            // Assert the pop-up alart message
            string newDescriptionAlertmMssage = ProfilePageObj.GetNewDescriptionAlertMessage(driver);
            Assert.That(newDescriptionAlertmMssage == "Description has been saved successfully", "Description has not been added.");
        }

        [When(@"I edit '([^']*)' on the existing description record")]

        public void WhenIEditOnTheExistingDescriptionRecord(string p0)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Edit description action
            ProfilePageObj.EditDescription(driver, p0);
        }

        [Then(@"The record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0)
        {
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the edited description on profile
            string editedDescription = ProfilePageObj.GetEditedDescription(driver);
            Assert.That(editedDescription == p0, "Actual record and expected record do not match.");

            // Assert the pop-up alert message
            string editedDescriptionAlertmMssage = ProfilePageObj.GetEditedDescriptionAlertMessage(driver);
            Assert.That(editedDescriptionAlertmMssage == "Description has been saved successfully", "Description has not been edited.");
        }



        [When(@"I delete description on profile")]
        public void WhenIDeleteDescriptionOnProfile()
        {
            ProfilePage ProfilePageObj = new ProfilePage();

            // Delete description action
            ProfilePageObj.DeleteDescription(driver);
        }

        [Then(@"The descrption should be deleted successfully")]
        public void ThenTheDescrptionShouldBeDeletedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();

            string deletedDescription = ProfilePageObj.GetDeletedDescription(driver);
            Assert.That(deletedDescription == "N/A", "Description has not been deleted.");


            // Assert the pop-up alert message
            string deletedDescriptionAlertmMssage = ProfilePageObj.GetDeletedDescriptionAlertMessage(driver);
            Assert.That(deletedDescriptionAlertmMssage == "Description has been saved successfully", "Description has not been deleted.");
        }
    }
}