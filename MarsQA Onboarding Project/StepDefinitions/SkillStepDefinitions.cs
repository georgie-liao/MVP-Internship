using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions : CommonDriver
    {
        [When(@"I add skill on profile")]
        public void WhenIAddSkillOnProfile()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Add skill action
            ProfilePageObj.AddSkill(driver);
        }

        [Then(@"The skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            // Assert the newly added skill
            string newSkill = ProfilePageObj.GetNewSkill(driver);
            string newSkillLevel = ProfilePageObj.GetNewSkillLevel(driver);
            Assert.That(newSkill == "Customer service skill", "Actual record and expected record do not match.");
            Assert.That(newSkillLevel == "Intermediate", "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new skill has been added
            string newSkillAlertmessage = ProfilePageObj.GetNewSkillAlertMessage(driver);
            Assert.That(newSkillAlertmessage == "Customer service skill has been added to your skills", "Expected pop up message is not matched.");
        }

        [When(@"I edit '([^']*)' and '([^']*)' on the existing skill record")]
        public void WhenIEditAndOnTheExistingSkillRecord(string p0, string p1)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            ProfilePageObj.EditSkill(driver, p0, p1);
        }

        [Then(@"The record should have edited '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveEditedAnd(string p0, string p1)
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            string editedSkill = ProfilePageObj.GetEditedSkill(driver);
            string editedSkillLevel = ProfilePageObj.GetEditedSkillLevel(driver);

            Assert.That(editedSkill == p0, "Actual record and expected record do not match.");
            Assert.That(editedSkillLevel == p1, "Actual record and expected record do not match.");

            // Assert the alart message to confirm the new skill has been edited
            string editedSkillAlertmessage = ProfilePageObj.GeteditedSkillAlertMessage(driver);
            Assert.That(editedSkillAlertmessage == p0 + " " + "has been updated to your skills", "Expected pop up message is not matched.");
        }

        [When(@"I delete a Skill from existing Skill records")]
        public void WhenIDeleteASkillFromExistingSkillRecords()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            ProfilePageObj.DeleteSkill(driver);
        }

        [Then(@"The skill record should be deleted successfully")]
        public void ThenTheSkillRecordShouldBeDeletedSuccessfully()
        {
            // User profile page initialization and definition
            ProfilePage ProfilePageObj = new ProfilePage();

            string deletedSkill = ProfilePageObj.GetdeletedSkill(driver);
            Assert.That(deletedSkill != "Teaching", "Actual record and expected record do not match.");

            // Check the alart message to confirm the deletion
            string SkillDeleteAlertMessage = ProfilePageObj.GetSkillDeleteAlertMessage(driver);
            Assert.That(SkillDeleteAlertMessage == "Teaching has been deleted", "Expected pop up message is not detected.");
        }



    }


}