using MarsQA.Pages;
using MarsQA.Utilities;
using MarsQA_Onboarding_Project.Pages.ProfilePage;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class DescriptionStepDefinitions : CommonDriver
    {
        // User profile page initialization and definition
        ManageDescription ManageDescriptionObj = new ManageDescription();

      
        [Given(@"I logged into portal")]
        public void GivenILoggedIntoPortal()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            // User profile page initialization and definition
            LoginPage LoginPageObj = new LoginPage();

            // Add description action
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"I add description on profile")]
        public void WhenIAddDescriptionOnProfile()
        {
            // Add description action
            ManageDescriptionObj.AddDescription(driver);
        }

        [Then(@"The description should be added successfully")]
        public void ThenTheDescriptionShouldBeAddedSuccessfully()
        {
            // Assert the newly added description on profile
            string newDescription = ManageDescriptionObj.GetNewDescription(driver);
            Assert.That(newDescription == "I'm a seller", "Actual record and expected record do not match.");

            // Assert the pop-up alart message
            string newDescriptionAlertmMssage = ManageDescriptionObj.GetNewDescriptionAlertMessage(driver);
            Assert.That(newDescriptionAlertmMssage == "Description has been saved successfully", "Description has not been added.");
        }

        [When(@"I edit '([^']*)' on the existing description record")]

        public void WhenIEditOnTheExistingDescriptionRecord(string p0)
        {
            // Edit description action
            ManageDescriptionObj.EditDescription(driver, p0);
        }

        [Then(@"The record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0)
        {
            // Assert the edited description on profile
            string editedDescription = ManageDescriptionObj.GetEditedDescription(driver);
            Assert.That(editedDescription == p0, "Actual record and expected record do not match.");

            // Assert the pop-up alert message
            string editedDescriptionAlertmMssage = ManageDescriptionObj.GetEditedDescriptionAlertMessage(driver);
            Assert.That(editedDescriptionAlertmMssage == "Description has been saved successfully", "Description has not been edited.");
        }



        [When(@"I delete description on profile")]
        public void WhenIDeleteDescriptionOnProfile()
        {
            // Delete description action
            ManageDescriptionObj.DeleteDescription(driver);
        }

        [Then(@"The descrption should be deleted successfully")]
        public void ThenTheDescrptionShouldBeDeletedSuccessfully()
        {
            string deletedDescription = ManageDescriptionObj.GetDeletedDescription(driver);
            Assert.That(deletedDescription == "N/A", "Description has not been deleted.");


            // Assert the pop-up alert message
            string deletedDescriptionAlertmMssage = ManageDescriptionObj.GetDeletedDescriptionAlertMessage(driver);
            Assert.That(deletedDescriptionAlertmMssage == "Description has been saved successfully", "Description has not been deleted.");
        }

    }
}