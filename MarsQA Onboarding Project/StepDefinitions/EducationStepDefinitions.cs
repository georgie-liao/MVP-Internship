using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {
        [When(@"I add educaiton on profile")]
        public void WhenIAddEducaitonOnProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add description action
            ProfilePageObj.AddEducation(driver);
        }

        [Then(@"Educaiton should be added successfully")]
        public void ThenEducaitonShouldBeAddedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the the newly added education
            string newUniversity = ProfilePageObj.GetNewUniversity(driver);
            string newCountryOfUniversity = ProfilePageObj.GetNewCountryOfUniversity(driver);
            string newTitle = ProfilePageObj.GetNewTitle(driver);
            string newDegree = ProfilePageObj.GetNewDegree(driver);
            string newYearOfGraducation = ProfilePageObj.GetNewYearOfGraducation(driver);
            Assert.That(newUniversity == "Auckland University", "Actual record and expected record do not match.");
            Assert.That(newCountryOfUniversity == "New Zealand", "Actual record and expected record do not match.");
            Assert.That(newTitle == "M.B.A", "Actual record and expected record do not match.");
            Assert.That(newDegree == "Master", "Actual record and expected record do not match.");
            Assert.That(newYearOfGraducation == "2018", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new education has been added
            string newEducationAlertmMssage = ProfilePageObj.GetNewEducationAlertMessage(driver);
            Assert.That(newEducationAlertmMssage == "Education has been added", "Expected pop up message is not matched.");
        }

        [When(@"I edit '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' on the existing description record")]
        public void WhenIEditOnTheExistingDescriptionRecord(string p0, string p1, string p2, string p3, string p4)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            ProfilePageObj.EditEducation(driver, p0, p1, p2, p3, p4);
        }

        [Then(@"The record shoud have edtied '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShoudHaveEdtied(string p0, string p1, string p2, string p3, string p4)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the newly edited education
            string editedUniversity = ProfilePageObj.GetEditedUniversity(driver);
            string editedCountryOfUniversity = ProfilePageObj.GetEditedCountryOfUniversity(driver);
            string editedTitle = ProfilePageObj.GetEditedTitle(driver);
            string editedDegree = ProfilePageObj.GetEditedDegree(driver);
            string editedYearOfGraducation = ProfilePageObj.GetEditedYearOfGraducation(driver);
            Assert.That(editedCountryOfUniversity == p0, "Actual record and expected record do not match.");
            Assert.That(editedUniversity == p1, "Actual record and expected record do not match.");
            Assert.That(editedTitle == p2, "Actual record and expected record do not match.");
            Assert.That(editedDegree == p3, "Actual record and expected record do not match.");
            Assert.That(editedYearOfGraducation == p4, "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new education has been edited
            string editedEducationAlertmMssage = ProfilePageObj.GetEditedEducationAlertMessage(driver);
            Assert.That(editedEducationAlertmMssage == "Education as been updated", "Expected pop up message is not matched.");
        }

        [When(@"I delete an education record")]
        public void WhenIDeleteAnEducationRecord()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            ProfilePageObj.DeleteEducation(driver);

        }

        [Then(@"The education record should be deleted successfully")]
        public void ThenTheEducationRecordShouldBeDeletedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the last record of Unniversity
            string deletedUniversity = ProfilePageObj.GetdeletedEducation(driver);
            Assert.That(deletedUniversity != "American University", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new education has been edited
            string editedEducationAlertmMssage = ProfilePageObj.GetEditedEducationAlertMessage(driver);
            Assert.That(editedEducationAlertmMssage == "Education entry successfully removed", "Expected pop up message is not matched.");
        }

    }
}