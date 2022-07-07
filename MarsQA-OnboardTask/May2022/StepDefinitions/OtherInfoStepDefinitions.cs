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

            // Add description action
            ProfilePageObj.AddOtherInfo(driver);
        }

        [Then(@"availability, hours, and earn target should be added to profile")]
        public void ThenAvailabilityHoursAndEarnTargetShouldBeAddedToProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the newly added availability, hours, and earn target on profile
            string newAailability = ProfilePageObj.GetNewAvailability(driver);
            string newHours = ProfilePageObj.GetNewHours(driver);
            string newEarnTarget = ProfilePageObj.GetNewEanTarget(driver);
            Assert.That(newAailability == "Part Time", "Description has not been added.");
            Assert.That(newHours == "Less than 30hours a week", "Description has not been added.");
            Assert.That(newEarnTarget == "Less than $500 per month", "Description has not been added.");

            // Assert the pop-up alart messages
            string newAvailablityAlertmMssage = ProfilePageObj.GetNewAvailabilityAlertMessage(driver);
            string newHoursAlertmMssage = ProfilePageObj.GetNewHoursAlertMessage(driver);
            string newEarnTargetAlertmMssage = ProfilePageObj.GetNewEarnTargetAlertMessage(driver);
            Assert.That(newAvailablityAlertmMssage == "Postgraduate diplomas has been added to your certification", "Experted alert message and actual message do not match.");
            Assert.That(newHoursAlertmMssage == "Postgraduate diplomas has been added to your certification", "Experted alert message and actual message do not match.");
            Assert.That(newEarnTargetAlertmMssage == "Postgraduate diplomas has been added to your certification", "Experted alert message and actual message do not match.");
        }
    }
}
