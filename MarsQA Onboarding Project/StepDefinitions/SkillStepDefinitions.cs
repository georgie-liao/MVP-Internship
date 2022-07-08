using MarsQA.Pages;
using MarsQA.Utilities;
using MarsQA_Onboarding_Project.Pages.ProfilePage;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions : CommonDriver
    {
        // User profile page initialization and definition
        ManageSkill ManageSkillObj = new ManageSkill();

        [Test]
        [When(@"I add skill on profile")]
        public void WhenIAddSkillOnProfile()
        {
            // Add skill action
            ManageSkillObj.AddSkill(driver);
        }

        [Then(@"The skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            // Assert the newly added skill
            string newSkill = ManageSkillObj.GetNewSkill(driver);
            string newSkillLevel = ManageSkillObj.GetNewSkillLevel(driver);
            Assert.That(newSkill == "Customer service skill", "Actual record and expected record do not match.");
            Assert.That(newSkillLevel == "Intermediate", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new skill has been added
            string newSkillAlertmessage = ManageSkillObj.GetNewSkillAlertMessage(driver);
            Assert.That(newSkillAlertmessage == "Customer service skill has been added to your skills", "Expected pop up message is not matched.");
        }

        [When(@"I edit '([^']*)' and '([^']*)' on the existing skill record")]
        public void WhenIEditAndOnTheExistingSkillRecord(string p0, string p1)
        {
            ManageSkillObj.EditSkill(driver, p0, p1);
        }

        [Then(@"The record should have edited '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveEditedAnd(string p0, string p1)
        {
            // Assert the edited skill
            string editedSkill = ManageSkillObj.GetEditedSkill(driver);
            string editedSkillLevel = ManageSkillObj.GetEditedSkillLevel(driver);
            Assert.That(editedSkill == p0, "Actual record and expected record do not match.");
            Assert.That(editedSkillLevel == p1, "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new skill has been edited
            string editedSkillAlertmessage = ManageSkillObj.GeteditedSkillAlertMessage(driver);
            Assert.That(editedSkillAlertmessage == p0 + " " + "has been updated to your skills", "Expected pop up message is not matched.");
        }

        [When(@"I delete a Skill from existing Skill records")]
        public void WhenIDeleteASkillFromExistingSkillRecords()
        {
            // Delete skill
            ManageSkillObj.DeleteSkill(driver);
        }

        [Then(@"The skill record should be deleted successfully")]
        public void ThenTheSkillRecordShouldBeDeletedSuccessfully()
        {
            // Assert deleted skill
            string deletedSkill = ManageSkillObj.GetdeletedSkill(driver);
            Assert.That(deletedSkill != "Teaching", "Actual record and expected record do not match.");

            // Check the alart message to confirm the deletion
            string SkillDeleteAlertMessage = ManageSkillObj.GetSkillDeleteAlertMessage(driver);
            Assert.That(SkillDeleteAlertMessage == "Teaching has been deleted", "Expected pop up message is not detected.");
        }

    }


}