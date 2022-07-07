using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class CertificationStepDefinitions : CommonDriver
    {
        [When(@"I add certification on profile")]
        public void WhenIAddCertificationOnProfile()
        {
             // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add description action
            ProfilePageObj.AddCertification(driver);

        }

        [Then(@"The certification should be added successfully")]
        public void ThenTheCertificationShouldBeAddedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the newly added description on profile
            string newCertification = ProfilePageObj.GetNewCertification(driver);
            string newCertificationFrom = ProfilePageObj.GetNewCertificationFrom(driver);
            string newCertificationYear = ProfilePageObj.GetNewCertificationYear(driver);
            Assert.That(newCertification == "Postgraduate diplomas", "Description has not been added.");
            Assert.That(newCertificationFrom == "Auckland University", "Description has not been added.");
            Assert.That(newCertificationYear == "2008", "Description has not been added.");

            // Assert the pop-up alart message
            string newCertificationAlertmMssage = ProfilePageObj.GetNewCertificationAlertMessage(driver);
            Assert.That(newCertificationAlertmMssage == "Postgraduate diplomas has been added to your certification", "Experted alert message and actual message do not match.");
        }

        [When(@"I edit '([^']*)','([^']*)' ,'([^']*)'on the existing Certification record")]
        public void WhenIEditOnTheExistingCertificationRecord(string p0, string p1, string p2)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add description action
            ProfilePageObj.EditCertification(driver, p0, p1, p2);

        }

        [Then(@"The record should have the edited '([^']*)','([^']*)' ,'([^']*)'")]
        public void ThenTheRecordShouldHaveTheEdited(string p0, string p1, string p2)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the newly added description on profile
            string editedCertification = ProfilePageObj.GetEditedCertification(driver);
            string editedCertificationFrom = ProfilePageObj.GetEditedCertificationFrom(driver);
            string editedCertificationYear = ProfilePageObj.GetEditedCertificationYear(driver);
            Assert.That(editedCertification == p0, "Actual record and expected record do not match.");
            Assert.That(editedCertificationFrom == p1, "Actual record and expected record do not match.");
            Assert.That(editedCertificationYear == p2, "Actual record and expected record do not match.");

            // Assert the pop-up alart message
            string editedCertificationAlertmMssage = ProfilePageObj.GetEditedCertificationAlertMessage(driver);
            Assert.That(editedCertificationAlertmMssage == p0 + " " + "has been updated to your certification", "Experted alert message and actual message do not match.");
        }

        [When(@"I delete a record of existing certification")]
        public void WhenIDeleteARecordOfExistingCertification()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add description action
            ProfilePageObj.DeleteCertification(driver);
            
        }

        [Then(@"The recrod should be deleted successfully")]
        public void ThenTheRecrodShouldBeDeletedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the last record of Certification
            string deletedCertification = ProfilePageObj.GetdeletedCertification(driver);
            Assert.That(deletedCertification != "American University", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the certification has been deleted
            string certificationDeleteAlertmMssage = ProfilePageObj.GetCertificationDeleteAlertMessage(driver);
            Assert.That(certificationDeleteAlertmMssage == "Certificate in Teaching has been deleted from your certification", "Expected pop up message is not matched.");

        }

    }
}
