using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class ProfilePage
    {

        //------Sart ----- Of ----- Description ----------------

        // Add description on profile
        public void AddDescription(IWebDriver driver) 
        {
            Thread.Sleep(3000);

           
            // Identify Description button and click, and add description 
            IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
                        descriptionButton.Click();

            Thread.Sleep(1000);
            // Enter desicription
            IWebElement descriptionTextBox = driver.FindElement(By.Name("value"));
                        descriptionTextBox.Clear();
                        descriptionTextBox.SendKeys("I'm a seller");

            Thread.Sleep(1000);

            // Idenfity and click on dscription Save button
            IWebElement descriptionSaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
                        descriptionSaveButton.Click();

        }

        public string GetNewDescriptionAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";

            IWebElement newDescriptionAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
                 return newDescriptionAlertmMssage.Text;
        }


        public string GetNewDescription(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement newDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
                 return newDescription.Text;
        }

        // Edit description on profile
        public void EditDescription(IWebDriver driver, string description)
        {
            Thread.Sleep(2000);

            // Identify Description button and click, then edit description 
            IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
                        descriptionButton.Click();

            Thread.Sleep(1000);
            // Enter desicription
            IWebElement descriptionTextBox = driver.FindElement(By.Name("value"));
                        descriptionTextBox.Clear();
                        descriptionTextBox.SendKeys(description);

            Thread.Sleep(1000);

            // Idenfity and click on dscription Save button
            IWebElement descriptionSaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
                        descriptionSaveButton.Click();

        }

        public string GetEditedDescriptionAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";

            IWebElement editedDescriptionAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedDescriptionAlertmMssage.Text;
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement editedDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
                 return editedDescription.Text;
        }

        // Delete description on profile
        public void DeleteDescription(IWebDriver driver)
        {
            Thread.Sleep(2000);

            // Identify Description button and click, then edit description 
            IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
                        descriptionButton.Click();

            Thread.Sleep(1000);

            // Clear desicription
            IWebElement descriptionTextBox = driver.FindElement(By.Name("value"));
                        descriptionTextBox.Clear();
                        descriptionTextBox.SendKeys("N/A");

            // Idenfity and click on dscription Save button
            IWebElement descriptionSaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
                        descriptionSaveButton.Click();
        }

        public string GetDeletedDescriptionAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";

            IWebElement deletedDescriptionAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return deletedDescriptionAlertmMssage.Text;
        }

        public string GetDeletedDescription(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement deletedDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
                 return deletedDescription.Text;
        }

        //------ End ----- of ----- Description ----------------


        //------ Start ----- of ----- Language ----------------

        // Add a new language to profile
        public void AddLanguage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement languageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageButton.Click();

            IWebElement languageAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            languageAddNewButton.Click();

            IWebElement addLanguageTextBox = driver.FindElement(By.Name("name"));
            addLanguageTextBox.SendKeys("English");

            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropdown.Click();

            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            chooseLanguageLevel.Click();

            IWebElement languageAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            languageAddButton.Click();

        }

        
        public string GetnewLanguageAlertMessage(IWebDriver driver) // Get the pop-up alert message
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";

            IWebElement newLanguageAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newLanguageAlertmMssage.Text;
        }

      
        public string GetNewLanguage(IWebDriver driver)   // Get the newly added language
        {
            Thread.Sleep(2000);

            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
                 return newLanguage.Text;

        }

        
        public string GetNewLanguageLevel(IWebDriver driver) // Get the newly added language level
        {

            Thread.Sleep(2000);

            IWebElement newLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newLanguageLevel.Text;
        }

        
        public void EditLanguage(IWebDriver driver, string language, string level) // Edit the record of the existing Languages
        {
            Thread.Sleep(1000);

            IWebElement languageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
                        languageButton.Click();

     

            IWebElement languageEditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr[last()]/td[3]/span[1]/i"));
                        languageEditButton.Click();

            

            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
                        languageTextBox.Clear();
                        languageTextBox.SendKeys(language);

            
            var selectLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select")));
                selectLanguageLevel.SelectByValue(level);


            IWebElement languageUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
                        languageUpdateButton.Click();
        }

        public string GeteditedLanguageAlertMessage(IWebDriver driver) // Get the pop-up alert message
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";

            IWebElement editedLanguageAlertmMessage = driver.FindElement(By.XPath(alertMessageXPath));
                 return editedLanguageAlertmMessage.Text;
        }

    
        public string GetEditedLanguage(IWebDriver driver)     // Get edited language
        {
            Thread.Sleep(2000);

            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr[last()]/td[1]"));
            return editedLanguage.Text;

        }

       
        public string GetEditedLanguageLevel(IWebDriver driver) // Get edited language level
        {

            Thread.Sleep(2000);

            IWebElement editedLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr[last()]/td[2]"));
            return editedLanguageLevel.Text;
        }

     
        
        public void DeleteLanguage(IWebDriver driver) // Delete the last record of existing languages
        {
            Thread.Sleep(2000);

            IWebElement deleteLanguageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr[last()]/td[3]/span[2]/i"));
                        deleteLanguageButton.Click();
        }
       
        public string GetDeletedLanguageAlertMessage(IWebDriver driver)  // Get the alert message 
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";

            IWebElement deletedLaguageAlertmessage = driver.FindElement(By.XPath(alertMessageXPath));
            return deletedLaguageAlertmessage.Text;
        }

        public string GetdeletedLanugage(IWebDriver driver) // check the last record of language for assert
        {

            Thread.Sleep(2000);

            IWebElement deletedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[last()]/td[1]"));
                 return deletedLanguage.Text;
        }
        //------ End ----- of ----- Language ----------------


        //------ Start ----- of ----- Skills ----------------

        public void AddSkill(IWebDriver driver) // Add a new skill on profile
        {
            Thread.Sleep(1000);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                        skillButton.Click();

            IWebElement skillAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
                        skillAddNewButton.Click();

            IWebElement addLanguageTextBox = driver.FindElement(By.Name("name"));
                        addLanguageTextBox.SendKeys("Customer service skill");

            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
                        skillLevelDropdown.Click();

            IWebElement chooseSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
                        chooseSkillLevel.Click();

            IWebElement skillAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
                        skillAddButton.Click();
        }

        public string GetNewSkillAlertMessage(IWebDriver driver)  // Get the new skill added alert message 
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newSkillAlertmessage = driver.FindElement(By.XPath(alertMessageXPath));
            return newSkillAlertmessage.Text;
        }


        public string GetNewSkill(IWebDriver driver) // Get the newly added skill
        {
            Thread.Sleep(2000);


            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();

            IWebElement newSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                 return newSkill.Text;

        }
        
        public string GetNewSkillLevel(IWebDriver driver) // Get the newly added skill level
        {
            Thread.Sleep(2000);

            IWebElement newSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
                 return newSkillLevel.Text;
        }

        
        public void EditSkill(IWebDriver driver, string skill, string level) // Edit an existing Skill record
        {
            Thread.Sleep(1000);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();


            IWebElement skillEditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
                        skillEditButton.Click();

            IWebElement skillTextBox = driver.FindElement(By.Name("name"));
                        skillTextBox.Clear();
                        skillTextBox.SendKeys(skill);

            var selectSkillLevel = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")));
            selectSkillLevel.SelectByValue(level);

            IWebElement skillUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
                        skillUpdateButton.Click();
        }

        public string GeteditedSkillAlertMessage(IWebDriver driver)  // Get the edited skill alert message 
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedSkillAlertmessage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedSkillAlertmessage.Text;
        }

        public string GetEditedSkill(IWebDriver driver) // Get edited skill
        {
            Thread.Sleep(2000);

            IWebElement editedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                 return editedSkill.Text;
        }
        public string GetEditedSkillLevel(IWebDriver driver)
        {

            Thread.Sleep(2000);

            IWebElement editedSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
                 return editedSkillLevel.Text;
        }

        // Delte an existing language
        public void DeleteSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();


            IWebElement deleteSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
                        deleteSkillButton.Click();
        }

        public string GetSkillDeleteAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(2000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";

            IWebElement skillDeleteAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return skillDeleteAlertmMssage.Text;
        }

        public string GetdeletedSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement deletedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                 return deletedSkill.Text;
        }

        //------ End ----- of ----- Skills ----------------

        //------ Start ----- of ----- Education ----------------

        public void AddEducation(IWebDriver driver) // Add a new skill on profile
        {
            Thread.Sleep(1000);

            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
                        educationButton.Click();

            IWebElement educationAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
                        educationAddNewButton.Click();

            IWebElement universityTextBox = driver.FindElement(By.Name("instituteName"));
                        universityTextBox.SendKeys("Auckland University");

            IWebElement countryOfUniversityDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
                        countryOfUniversityDropdown.Click();

            IWebElement chooseCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
                        chooseCountryOfUniversity.Click();

            IWebElement titleDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
                        titleDropdown.Click();

            IWebElement chooseTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[10]"));
                        chooseTitle.Click();

            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
                        degreeTextBox.SendKeys("Master");

            IWebElement yearOfGraducationDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
                        yearOfGraducationDropdown.Click();

            IWebElement chooseYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[6]"));
                        chooseYearOfGraducation.Click();

            IWebElement educationAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
                        educationAddButton.Click();
        }

        public string GetNewEducationAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newEducationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newEducationAlertmMssage.Text;
        }

        public string GetNewUniversity(IWebDriver driver)
        {
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            Thread.Sleep(1000);

            IWebElement newUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[2]"));
                 return newUniversity.Text;
        }

        public string GetNewCountryOfUniversity(IWebDriver driver)
        {

            IWebElement newCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[1]"));
                 return newCountryOfUniversity.Text;
        }

        public string GetNewTitle(IWebDriver driver)
        {

            IWebElement newTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[3]"));
                 return newTitle.Text;
        }

        public string GetNewDegree(IWebDriver driver)
        {

            IWebElement newDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[4]"));
                 return newDegree.Text;
        }

        public string GetNewYearOfGraducation(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement newYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[5]"));
                 return newYearOfGraducation.Text;
        }

        public void EditEducation(IWebDriver driver, string country, string unviversity, string title, string degree, string graduationYear) // Add a new skill on profile
        {
            Thread.Sleep(1000);

            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            IWebElement editEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i"));
                        editEducationButton.Click();                       

            IWebElement editUniversityTextBox = driver.FindElement(By.Name("instituteName"));
                        editUniversityTextBox.Clear();
                        editUniversityTextBox.SendKeys(unviversity);

            var selectCountryOfUniversity = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td/div[1]/div[2]/select")));
                selectCountryOfUniversity.SelectByValue(country);

            var selectTitle = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[last()]//div[2]/div[1]/select")));
                selectTitle.SelectByValue(title);

            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
                        degreeTextBox.Clear();
                        degreeTextBox.SendKeys(degree);

            var selectYearOfGraducation = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td/div[2]/div[3]/select")));
                selectYearOfGraducation.SelectByValue(graduationYear);

            IWebElement educationUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[last()]//div[3]/input[1]"));
                        educationUpdateButton.Click();
        }

        public string GetEditedEducationAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedEducationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
                 return editedEducationAlertmMssage.Text;
        }

        public string GetEditedCountryOfUniversity(IWebDriver driver)
        {
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            Thread.Sleep(1000);

            IWebElement editedCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[1]"));
            return editedCountryOfUniversity.Text;
        }

        public string GetEditedUniversity(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement editedUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[2]"));
                 return editedUniversity.Text;
        }

     
        public string GetEditedTitle(IWebDriver driver)
        {

            IWebElement editedTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[3]"));
                 return editedTitle.Text;
        }

        public string GetEditedDegree(IWebDriver driver)
        {

            IWebElement editedDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[4]"));
                 return editedDegree.Text;
        }

        public string GetEditedYearOfGraducation(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement editedYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]//tr/td[5]"));
                 return editedYearOfGraducation.Text;
        }

       
        public void DeleteEducation(IWebDriver driver)  // Delte an existing education record
        {
            Thread.Sleep(1000);

            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            IWebElement deleteEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i"));
                        deleteEducationButton.Click();
        }

        public string GetEducationDeleteAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement educationDeleteAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return educationDeleteAlertmMssage.Text;
        }

        public string GetdeletedEducation(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement deletedEducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr[1]/td[2]"));
            return deletedEducation.Text;
        }
        //------  ----- of ----- Education ----------------

        //------ Start ----- of ----- Certification ----------------

        public void AddCertification(IWebDriver driver) // Add a new certification on profile
        {
            Thread.Sleep(1000);

            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
                        certificationButton.Click();

            IWebElement certificationAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
                        certificationAddNewButton.Click();

            IWebElement CertificationTextBox = driver.FindElement(By.Name("certificationName"));
                        CertificationTextBox.SendKeys("Postgraduate diplomas");

            IWebElement CertificationFromTextBox = driver.FindElement(By.Name("certificationFrom"));
                        CertificationFromTextBox.SendKeys("Auckland University");

            var selectYearOfCertification = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
                selectYearOfCertification.SelectByValue("2008");

            IWebElement addCertificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
                        addCertificationButton.Click();
        }

        public string GetNewCertificationAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newCertificationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
                 return newCertificationAlertmMssage.Text;
        }

        public string GetNewCertification(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement newCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
                 return newCertification.Text;
        }

        public string GetNewCertificationFrom(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement newCertificationFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
                 return newCertificationFrom.Text;
        }

        public string GetNewCertificationYear(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement newCertificationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
                 return newCertificationYear.Text;
        }

        public void EditCertification(IWebDriver driver, string certificate, string certificateFrom, string certificateYear) // Edit an existing certification on profile
        {
            Thread.Sleep(1000);

            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            IWebElement certificationEditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
                        certificationEditButton.Click();

            IWebElement editcertificationTextBox = driver.FindElement(By.Name("certificationName"));
                        editcertificationTextBox.Clear();
                        editcertificationTextBox.SendKeys(certificate);

            IWebElement CertificationFromTextBox = driver.FindElement(By.Name("certificationFrom"));
                        CertificationFromTextBox.Clear();
                        CertificationFromTextBox.SendKeys(certificateFrom);

            var selectYearOfCertification = new SelectElement(driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[3]/select")));
            selectYearOfCertification.SelectByValue(certificateYear);

            IWebElement certificationUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
                        certificationUpdateButton.Click();
        }

        public string GetEditedCertificationAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement editedCertificationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return editedCertificationAlertmMssage.Text;
        }

        public string GetEditedCertification(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement editedCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
                 return editedCertification.Text;
        }

        public string GetEditedCertificationFrom(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement editedCertificationFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
                 return editedCertificationFrom.Text;
        }

        public string GetEditedCertificationYear(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement editedCertificationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
                 return editedCertificationYear.Text;
        }


        public void DeleteCertification(IWebDriver driver)  // Delte an existing education record
        {
            Thread.Sleep(1000);

            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            IWebElement deleteCertificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
                        deleteCertificationButton.Click();
        }

        public string GetdeletedCertification(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement deletedCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table[last()]/tbody[2]/tr/td[1]"));
                 return deletedCertification.Text;
        }

        public string GetCertificationDeleteAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement certificationDeleteAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
                 return certificationDeleteAlertmMssage.Text;
        }
        //------ End ----- of ----- Certification ----------------

        //------ Start ----- of ----- other information ----------------

        public void AddOtherInfo(IWebDriver driver) // Add availability, hours and earn target on profile
        {
            IWebElement addAvailabilityButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
                        addAvailabilityButton.Click();

            IWebElement availabilityDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
                        availabilityDropdown.Click();

            IWebElement chooseAvailability = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
                        chooseAvailability.Click();

            IWebElement addHoursButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
                        addHoursButton.Click();

            IWebElement hoursDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
                        hoursDropdown.Click();

            IWebElement chooseHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[2]"));
                        chooseHours.Click();

            IWebElement addEarnTargetButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
                        addEarnTargetButton.Click();

            IWebElement earnTargetDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
                        earnTargetDropdown.Click();

            IWebElement chooseEarnTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[2]"));
                        chooseEarnTarget.Click();
        }

        public string GetNewAvailability(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement newAvailability = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/text()"));
                 return newAvailability.Text;
        }

        public string GetNewAvailabilityAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newAvailablityAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
                 return newAvailablityAlertmMssage.Text;
        }


        public string GetNewHours(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement newHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/text()"));
                 return newHours.Text;
        }

        public string GetNewHoursAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newHoursAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newHoursAlertmMssage.Text;
        }

        public string GetNewEanTarget(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement newEartTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/text()"));
                 return newEartTarget.Text;
        }

        public string GetNewEarnTargetAlertMessage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newEarnTargetAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newEarnTargetAlertmMssage.Text;
        }
    }
}

