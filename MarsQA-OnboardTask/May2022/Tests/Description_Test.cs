//using MarsQA.Pages;
//using MarsQA.Utilities;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MarsQA.Tests
//{
//    [TestFixture]
//    [Parallelizable]
//    internal class Description_Test : CommonDriver
//    {
//        LoginPage loginpageObj = new LoginPage();
//        UserProfilePage UserProfilePageObj = new UserProfilePage();

//        //[Test, Description("Add profile details")]
//        public void AddProfileDetails()
//        {
//            // Login as a user
//            loginpageObj.LoginSteps(driver);

//            // Add profile detials action
//            UserProfilePageObj.AddDescription(driver);

//        }

//        [Test, Order(2), Description("Edit description on profile")]
//        public void EditDescription()
//        {
//            // Login to the portal
//            loginpageObj.LoginSteps(driver);

//            // Edit profile description action
//            UserProfilePageObj.EditDescription(driver, "dummy");

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
