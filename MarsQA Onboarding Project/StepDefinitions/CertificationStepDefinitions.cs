using MarsQA.Pages;
using MarsQA.Utilities;
using MarsQA_Onboarding_Project.Pages.ProfilePage;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class CertificationStepDefinitions : CommonDriver
    {

        // User profile page initialization and definition
        ManageCertification ManageCertificationObj = new ManageCertification();

        [When(@"I add certification on profile")]
        public void WhenIAddCertificationOnProfile()
        {
            // Add description action
            ManageCertificationObj.AddCertification(driver);

        }

        [Then(@"The certification should be added successfully")]
        public void ThenTheCertificationShouldBeAddedSuccessfully()
        {
            // Assert the newly added description on profile
            string newCertification = ManageCertificationObj.GetNewCertification(driver);
            string newCertificationFrom = ManageCertificationObj.GetNewCertificationFrom(driver);
            string newCertificationYear = ManageCertificationObj.GetNewCertificationYear(driver);
            Assert.That(newCertification == "Postgraduate diplomas", "Description has not been added.");
            Assert.That(newCertificationFrom == "Auckland University", "Description has not been added.");
            Assert.That(newCertificationYear == "2008", "Description has not been added.");

            // Assert the pop-up alart message
            string newCertificationAlertmMssage = ManageCertificationObj.GetNewCertificationAlertMessage(driver);
            Assert.That(newCertificationAlertmMssage == "Postgraduate diplomas has been added to your certification", "Experted alert message and actual message do not match.");
        }

        [When(@"I edit '([^']*)','([^']*)' ,'([^']*)'on the existing Certification record")]
        public void WhenIEditOnTheExistingCertificationRecord(string p0, string p1, string p2)
        {
            // Add description action
            ManageCertificationObj.EditCertification(driver, p0, p1, p2);

        }

        [Then(@"The record should have the edited '([^']*)','([^']*)' ,'([^']*)'")]
        public void ThenTheRecordShouldHaveTheEdited(string p0, string p1, string p2)
        {
            // Assert the newly added description on profile
            string editedCertification = ManageCertificationObj.GetEditedCertification(driver);
            string editedCertificationFrom = ManageCertificationObj.GetEditedCertificationFrom(driver);
            string editedCertificationYear = ManageCertificationObj.GetEditedCertificationYear(driver);
            Assert.That(editedCertification == p0, "Actual record and expected record do not match.");
            Assert.That(editedCertificationFrom == p1, "Actual record and expected record do not match.");
            Assert.That(editedCertificationYear == p2, "Actual record and expected record do not match.");

            // Assert the pop-up alart message
            string editedCertificationAlertmMssage = ManageCertificationObj.GetEditedCertificationAlertMessage(driver);
            Assert.That(editedCertificationAlertmMssage == p0 + " " + "has been updated to your certification", "Experted alert message and actual message do not match.");
        }

        [When(@"I delete a record of existing certification")]
        public void WhenIDeleteARecordOfExistingCertification()
        {
            // Add description action
            ManageCertificationObj.DeleteCertification(driver);

        }

        [Then(@"The recrod should be deleted successfully")]
        public void ThenTheRecrodShouldBeDeletedSuccessfully()
        {
            // Assert the last record of Certification
            string deletedCertification = ManageCertificationObj.GetdeletedCertification(driver);
            Assert.That(deletedCertification != "American University", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the certification has been deleted
            string certificationDeleteAlertmMssage = ManageCertificationObj.GetCertificationDeleteAlertMessage(driver);
            Assert.That(certificationDeleteAlertmMssage == "Certificate in Teaching has been deleted from your certification", "Expected pop up message is not matched.");

        }

    }
}