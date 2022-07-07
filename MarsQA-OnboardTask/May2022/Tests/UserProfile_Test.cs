//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using MarsQA.Utilities;
//using MarsQA.Pages;

//namespace MarsQA.Tests
//{
//    [TestFixture]
//    [Parallelizable]
//    public class UserProfile_Test: CommonDriver
//    {
//        // Page object initialization
//        LoginPage loginpageObj = new LoginPage();
//        UserProfilePage UserProfilePageObj = new UserProfilePage();

//        [Test, Order(1), Description("Add description on profile")]
//        public void AddDescription()
//        {
//            // Login to the portal
//            loginpageObj.LoginSteps(driver);

//            // Add profile description action
//            UserProfilePageObj.AddDescription(driver);

//        }


//        [Test, Order(2), Description("Edit description on profile")]
//        public void EditDescription()
//        {
//            // Login to the portal
//            loginpageObj.LoginSteps(driver);

//            // Edit profile description action
//            UserProfilePageObj.EditDescription(driver,"dummy");

//        }

//        [Test, Order(3), Description("Delete description on profile")]
//        public void DeleteDescription()
//        {
//            // Login to the portal
//            loginpageObj.LoginSteps(driver);

//            // Edit profile description action
//            UserProfilePageObj.DeleteDescription(driver);

//        }

//    }
//}
