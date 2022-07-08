using MarsQA.Pages;
using MarsQA.Utilities;
using MarsQA_Onboarding_Project.Pages.ProfilePage;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class OtherInfoStepDefinitions : CommonDriver
    {
        // User profile page initialization and definition
        ManageOtherInfo ManageOtherInfoObj = new ManageOtherInfo();

 
        [When(@"I add availability, hours, and earn target on profile")]
        public void WhenIAddAvailabilityHoursAndEarnTargetOnProfile()
        {
            // Add other info action
            ManageOtherInfoObj.AddOtherInfo(driver);
        }

        [Then(@"availability, hours, and earn target should be added to profile")]
        public void ThenAvailabilityHoursAndEarnTargetShouldBeAddedToProfile()
        {
            // Assert the newly added availability, hours, and earn target on profile
            string newAvailability = ManageOtherInfoObj.GetNewAvailability(driver);
            string newHours = ManageOtherInfoObj.GetNewHours(driver);
            string newEarnTarget = ManageOtherInfoObj.GetNewEanTarget(driver);
            Assert.That(newAvailability == "Part Time", "Description has not been added.");
            Assert.That(newHours == "Less than 30hours a week", "Description has not been added.");
            Assert.That(newEarnTarget == "Less than $500 per month", "Description has not been added.");

            // Assert the pop-up alart messages
            string newAvailablityAlertmMssage = ManageOtherInfoObj.GetNewAvailabilityAlertMessage(driver);
            string newHoursAlertmMssage = ManageOtherInfoObj.GetNewHoursAlertMessage(driver);
            string newEarnTargetAlertmMssage = ManageOtherInfoObj.GetNewEarnTargetAlertMessage(driver);
            Assert.That(newAvailablityAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newHoursAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newEarnTargetAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
        }

        [When(@"I edit availability, hous, and earn target on profile")]
        public void WhenIEditAvailabilityHousAndEarnTargetOnProfile()
        {
            // Edit other info action
            ManageOtherInfoObj.EditOtherInfo(driver);
        }

        [Then(@"The record should have edited availability, hous, and earn target")]
        public void ThenTheRecordShouldHaveEditedAvailabilityHousAndEarnTarget()
        {
            // Assert the edited availability, hours, and earn target on profile
            string editAvailability = ManageOtherInfoObj.GetEditedAvailability(driver);
            string editedHours = ManageOtherInfoObj.GetEditedHours(driver);
            string editedEarnTarget = ManageOtherInfoObj.GetEditedEanTarget(driver);
            Assert.That(editAvailability == "Full Time", "Description has not been added.");
            Assert.That(editedHours == "More than 30hours a week", "Description has not been added.");
            Assert.That(editedEarnTarget == "Between $500 and $1000 per month", "Description has not been added.");

            // Assert the pop-up alart messages
            string newAvailablityAlertmMssage = ManageOtherInfoObj.GetNewAvailabilityAlertMessage(driver);
            string newHoursAlertmMssage = ManageOtherInfoObj.GetNewHoursAlertMessage(driver);
            string newEarnTargetAlertmMssage = ManageOtherInfoObj.GetNewEarnTargetAlertMessage(driver);
            Assert.That(newAvailablityAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newHoursAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
            Assert.That(newEarnTargetAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
        }

    }
}