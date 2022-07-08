using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class OtherInfoStepDefinitions : CommonDriver
    {
        [When(@"I add availability, hours, and earn target on profile")]
        public void WhenIAddAvailabilityHoursAndEarnTargetOnProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add other info action
            ProfilePageObj.AddOtherInfo(driver);
        }

        [Then(@"availability, hours, and earn target should be added to profile")]
        public void ThenAvailabilityHoursAndEarnTargetShouldBeAddedToProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the newly added availability, hours, and earn target on profile
            string newAvailability = ProfilePageObj.GetNewAvailability(driver);
            string newHours = ProfilePageObj.GetNewHours(driver);
            string newEarnTarget = ProfilePageObj.GetNewEanTarget(driver);
            Assert.That(newAvailability == "Part Time", "Description has not been added.");
            Assert.That(newHours == "Less than 30hours a week", "Description has not been added.");
            Assert.That(newEarnTarget == "Less than $500 per month", "Description has not been added.");

            // Assert the pop-up alart messages
            string newAvailablityAlertmMssage = ProfilePageObj.GetNewAvailabilityAlertMessage(driver);
            string newHoursAlertmMssage = ProfilePageObj.GetNewHoursAlertMessage(driver);
            string newEarnTargetAlertmMssage = ProfilePageObj.GetNewEarnTargetAlertMessage(driver);
            Assert.That(newAvailablityAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newHoursAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newEarnTargetAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
        }

        [When(@"I edit availability, hous, and earn target on profile")]
        public void WhenIEditAvailabilityHousAndEarnTargetOnProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Edit other info action
            ProfilePageObj.EditOtherInfo(driver);
        }

        [Then(@"The record should have edited availability, hous, and earn target")]
        public void ThenTheRecordShouldHaveEditedAvailabilityHousAndEarnTarget()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the edited availability, hours, and earn target on profile
            string editAvailability = ProfilePageObj.GetEditedAvailability(driver);
            string editedHours = ProfilePageObj.GetEditedHours(driver);
            string editedEarnTarget = ProfilePageObj.GetEditedEanTarget(driver);
            Assert.That(editAvailability == "Full Time", "Description has not been added.");
            Assert.That(editedHours == "More than 30hours a week", "Description has not been added.");
            Assert.That(editedEarnTarget == "Between $500 and $1000 per month", "Description has not been added.");

            // Assert the pop-up alart messages
            string newAvailablityAlertmMssage = ProfilePageObj.GetNewAvailabilityAlertMessage(driver);
            string newHoursAlertmMssage = ProfilePageObj.GetNewHoursAlertMessage(driver);
            string newEarnTargetAlertmMssage = ProfilePageObj.GetNewEarnTargetAlertMessage(driver);
            Assert.That(newAvailablityAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newHoursAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newEarnTargetAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
        }

    }
}