using System;
using TechTalk.SpecFlow;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject
{
    [Binding]
    public class LoginSteps
    {
        DriverManagement driver;
        LoginPage loginPage;
        HomePage homePage;

        LoginSteps()
        {
         
            driver = DriverManagement.getDriver("https://www.hudl.com/login");
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
        }

         private void InsertUsernameAndPassword(string name, string password)
        {
            loginPage.InsertUserName(name);
            loginPage.InsertPassword(password);
        }



        [Given(@"the user insered the right credential")]
        public void GivenTheUserInseredTheRightCredential()
        {
            InsertUsernameAndPassword("puddu.alessandra@gmail.com", "123Stella$");
        }

        [Given(@"the user insered the wrong credential")]
        public void GivenTheUserInseredTheWrongCredential()
        {
            InsertUsernameAndPassword("puddu.allessandra@gmail.com", "123Stella$");
        }


        [Given(@"the user insered the a bad formatted mail and a password")]
        public void GivenTheUserInseredTheABadFormattedMailAndAPassword()
        {
            InsertUsernameAndPassword("puddu.alessandragmail.com", "123Stella$");
        }

        [When(@"the user click the Login button")]
        public void WhenTheUserClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }
        
        [Then(@"Home page is displayed")]
        public void ThenHomePageIsDisplayed()
        {
            Assert.IsTrue(homePage.IsHomePageDisplayed(), "Home page is not Displayed");
        }

        [Then(@"an error message is displayed")]
        public void ThenAnErrorMessageIsDisplayed()
        {
            Assert.IsTrue(loginPage.IsTheErrorMesssagePresent(), "Error Message is not Displayed");
        }

        [Given(@"the user has inserted the mail but does not remember the password")]
        public void GivenTheUserHasInsertedTheMailButDoesNotRememberThePassword()
        {
            loginPage.InsertUserName("puddu.alessandra@gmail.com");

        }

        [When(@"the user click the  need help button")]
        public void WhenTheUserClickTheNeedHelpButton()
        {
            loginPage.ClickTheForgotPasswordLink();
        }

        [Then(@"the reset password form is displayed")]
        public void ThenTheResetPasswordFormIsDisplayed()
        {
            Assert.IsTrue(loginPage.IsTheResetPasswordFormDispalyed(), "The Reset password form is not displayed");
        }



        [AfterScenario]
        public void TestCleanUp()
        {
            driver.Close();

        }
    }
}
