using MarsQA.Pages;
using MarsQA.Utilities;
using MarsQA_Onboarding_Project.Pages.ProfilePage;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {

        // User profile page initialization and definition
        ManageEducation ManageEducationObj = new ManageEducation();

        [When(@"I add educaiton on profile")]
        public void WhenIAddEducaitonOnProfile()
        {
            // Add description action
            ManageEducationObj.AddEducation(driver);
        }

        [Then(@"Educaiton should be added successfully")]
        public void ThenEducaitonShouldBeAddedSuccessfully()
        {
            // Assert the the newly added education
            string newUniversity = ManageEducationObj.GetNewUniversity(driver);
            string newCountryOfUniversity = ManageEducationObj.GetNewCountryOfUniversity(driver);
            string newTitle = ManageEducationObj.GetNewTitle(driver);
            string newDegree = ManageEducationObj.GetNewDegree(driver);
            string newYearOfGraducation = ManageEducationObj.GetNewYearOfGraducation(driver);
            Assert.That(newUniversity == "Auckland University", "Actual record and expected record do not match.");
            Assert.That(newCountryOfUniversity == "New Zealand", "Actual record and expected record do not match.");
            Assert.That(newTitle == "M.B.A", "Actual record and expected record do not match.");
            Assert.That(newDegree == "Master", "Actual record and expected record do not match.");
            Assert.That(newYearOfGraducation == "2018", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new education has been added
            string newEducationAlertmMssage = ManageEducationObj.GetNewEducationAlertMessage(driver);
            Assert.That(newEducationAlertmMssage == "Education has been added", "Expected pop up message is not matched.");
        }

        [When(@"I edit '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' on the existing description record")]
        public void WhenIEditOnTheExistingDescriptionRecord(string p0, string p1, string p2, string p3, string p4)
        {
            // Edit education 
            ManageEducationObj.EditEducation(driver, p0, p1, p2, p3, p4);
        }

        [Then(@"The record shoud have edtied '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShoudHaveEdtied(string p0, string p1, string p2, string p3, string p4)
        {
            // Assert the newly edited education
            string editedUniversity = ManageEducationObj.GetEditedUniversity(driver);
            string editedCountryOfUniversity = ManageEducationObj.GetEditedCountryOfUniversity(driver);
            string editedTitle = ManageEducationObj.GetEditedTitle(driver);
            string editedDegree = ManageEducationObj.GetEditedDegree(driver);
            string editedYearOfGraducation = ManageEducationObj.GetEditedYearOfGraducation(driver);
            Assert.That(editedCountryOfUniversity == p0, "Actual record and expected record do not match.");
            Assert.That(editedUniversity == p1, "Actual record and expected record do not match.");
            Assert.That(editedTitle == p2, "Actual record and expected record do not match.");
            Assert.That(editedDegree == p3, "Actual record and expected record do not match.");
            Assert.That(editedYearOfGraducation == p4, "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new education has been edited
            string editedEducationAlertmMssage = ManageEducationObj.GetEditedEducationAlertMessage(driver);
            Assert.That(editedEducationAlertmMssage == "Education as been updated", "Expected pop up message is not matched.");
        }

        [When(@"I delete an education record")]
        public void WhenIDeleteAnEducationRecord()
        {
            ManageEducationObj.DeleteEducation(driver);

        }

        [Then(@"The education record should be deleted successfully")]
        public void ThenTheEducationRecordShouldBeDeletedSuccessfully()
        {
            // Assert the last record of Unniversity
            string deletedUniversity = ManageEducationObj.GetdeletedEducation(driver);
            Assert.That(deletedUniversity != "American University", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new education has been edited
            string editedEducationAlertmMssage = ManageEducationObj.GetEditedEducationAlertMessage(driver);
            Assert.That(editedEducationAlertmMssage == "Education entry successfully removed", "Expected pop up message is not matched.");
        }

    }
}