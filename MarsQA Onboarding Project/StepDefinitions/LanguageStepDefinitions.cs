using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver
    {
        [When(@"I add language on my profile")]
        public void WhenIAddLanguageOnMyProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add description action
            ProfilePageObj.AddLanguage(driver);
        }

        [Then(@"The language should added successfully")]
        public void ThenTheLanguageShouldAddedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the the newly added language and language level
            string newLanguage = ProfilePageObj.GetNewLanguage(driver);
            string newLanguageLevel = ProfilePageObj.GetNewLanguageLevel(driver);
            Assert.That(newLanguage == "English", "Actual record and expected record do not match.");
            Assert.That(newLanguageLevel == "Fluent", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new language has been added
            string newLanguageAlertmMssage = ProfilePageObj.GetnewLanguageAlertMessage(driver);
            Assert.That(newLanguageAlertmMssage == "English has been added to your languages", "Expected pop up message is not matched.");
        }

        [When(@"I edite '([^']*)' and '([^']*)'on an existing language record")]
        public void WhenIEditeAndOnAnExistingLanguageRecord(string p0, string p1)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            ProfilePageObj.EditLanguage(driver, p0, p1);
        }

        [Then(@"The record should have the edited '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheEditedAnd(string p0, string p1)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the edited languages and levels
            string editedLanguage = ProfilePageObj.GetEditedLanguage(driver);
            string editedLanguageLevel = ProfilePageObj.GetEditedLanguageLevel(driver);
            Assert.That(editedLanguage == p0, "Actual record and expected record do not match.");
            Assert.That(editedLanguageLevel == p1, "Actual record and expected record do not match.");

            // Asser the pop-up alert message
            string editedLanguageAlertmMessage = ProfilePageObj.GeteditedLanguageAlertMessage(driver);
            Assert.That(editedLanguageAlertmMessage == p0 + " " + "has been updated to your languages", "Actual alert message does not match.");
        }

        [When(@"I delete a language from an existing language record")]
        public void WhenIDeleteALanguageFromAnExistingLanguageRecord()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            ProfilePageObj.DeleteLanguage(driver);

        }

        [Then(@"The language record should be deleted successfully")]
        public void ThenTheLanguageRecordShouldBeDeletedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the last record of language
            string deletedLanguage = ProfilePageObj.GetdeletedLanugage(driver);
            Assert.That(deletedLanguage != "Spanish", "Expected language record has not been deleted successfully.");

            // Assert the alert message to confirm the deletion
            string deletedLaguageAlertmessage = ProfilePageObj.GetDeletedLanguageAlertMessage(driver);
            Assert.That(deletedLaguageAlertmessage == "Spanish has been deleted from your languages", "Expected pop up message is not detected.");
        }

    }
}