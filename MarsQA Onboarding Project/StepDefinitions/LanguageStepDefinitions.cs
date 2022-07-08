using MarsQA.Pages;
using MarsQA.Utilities;
using MarsQA_Onboarding_Project.Pages.ProfilePage;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver
    {

        // User profile page initialization and definition
        ManageLanguage ManageLanguageObj = new ManageLanguage();

        [When(@"I add language on my profile")]
        public void WhenIAddLanguageOnMyProfile()
        {
            // Add description action
            ManageLanguageObj.AddLanguage(driver);
        }

        [Then(@"The language should added successfully")]
        public void ThenTheLanguageShouldAddedSuccessfully()
        {
            // Assert the the newly added language and language level
            string newLanguage = ManageLanguageObj.GetNewLanguage(driver);
            string newLanguageLevel = ManageLanguageObj.GetNewLanguageLevel(driver);
            Assert.That(newLanguage == "English", "Actual record and expected record do not match.");
            Assert.That(newLanguageLevel == "Fluent", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new language has been added
            string newLanguageAlertmMssage = ManageLanguageObj.GetnewLanguageAlertMessage(driver);
            Assert.That(newLanguageAlertmMssage == "English has been added to your languages", "Expected pop up message is not matched.");
        }

        [When(@"I edite '([^']*)' and '([^']*)'on an existing language record")]
        public void WhenIEditeAndOnAnExistingLanguageRecord(string p0, string p1)
        {
            ManageLanguageObj.EditLanguage(driver, p0, p1);
        }

        [Then(@"The record should have the edited '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheEditedAnd(string p0, string p1)
        {
            // Assert the edited languages and levels
            string editedLanguage = ManageLanguageObj.GetEditedLanguage(driver);
            string editedLanguageLevel = ManageLanguageObj.GetEditedLanguageLevel(driver);
            Assert.That(editedLanguage == p0, "Actual record and expected record do not match.");
            Assert.That(editedLanguageLevel == p1, "Actual record and expected record do not match.");

            // Asser the pop-up alert message
            string editedLanguageAlertmMessage = ManageLanguageObj.GeteditedLanguageAlertMessage(driver);
            Assert.That(editedLanguageAlertmMessage == p0 + " " + "has been updated to your languages", "Actual alert message does not match.");
        }

        [When(@"I delete a language from an existing language record")]
        public void WhenIDeleteALanguageFromAnExistingLanguageRecord()
        {
            ManageLanguageObj.DeleteLanguage(driver);
        }

        [Then(@"The language record should be deleted successfully")]
        public void ThenTheLanguageRecordShouldBeDeletedSuccessfully()
        {
            // Assert the last record of language
            string deletedLanguage = ManageLanguageObj.GetdeletedLanugage(driver);
            Assert.That(deletedLanguage != "Spanish", "Expected language record has not been deleted successfully.");

            // Assert the alert message to confirm the deletion
            string deletedLaguageAlertmessage = ManageLanguageObj.GetDeletedLanguageAlertMessage(driver);
            Assert.That(deletedLaguageAlertmessage == "Spanish has been deleted from your languages", "Expected pop up message is not detected.");
        }


    }
}