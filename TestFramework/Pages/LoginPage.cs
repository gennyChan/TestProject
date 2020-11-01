using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras;

namespace TestFramework
{
   public  class LoginPage : BasePage
    {  
        private readonly By _txtUsernameLocator = By.Id("email");
        private readonly By _txtPasswordLocator = By.Id("password");
        private readonly By _btnSignInButtonLocator = By.Id("logIn");
        private readonly By _forgotPasswordLink = By.Id("forgot-password-link");
        private readonly By _errorMessage = By.XPath("//div[contains(@class, 'login-error-container')]");
        private readonly By _resetBtnk = By.Id("resetBtn");
      

        public LoginPage(DriverManagement driver) : base (driver)
        {
            //_driver = driver;
        }

        private IWebElement TxtUsernameLocator
        {
            get { return GetWebElement(_txtUsernameLocator); }
        }

        private IWebElement TxtPasswordLocator
        {
            get { return GetWebElement(_txtPasswordLocator); }
        }

        private IWebElement BtnSignInButtonLocator
        {
            get { return GetWebElement(_btnSignInButtonLocator); }
        }

        private IWebElement ErrorMessage
        {
            get { return GetWebElement(_errorMessage); }
        }

      
        private IWebElement ForgotPasswordLink
        {
            get { return GetWebElement(_forgotPasswordLink); }
        }

   
        private IWebElement ResetBtnk
        {
            get { return GetWebElement(_resetBtnk); }
        }


        public void InsertUserName(string username)
        {
            TxtUsernameLocator.SendKeys(username);
        }


        public void InsertPassword(string password)
        {
            TxtPasswordLocator.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            BtnSignInButtonLocator.Click();
        }

        public void ClickTheForgotPasswordLink()
        {
            ForgotPasswordLink.Click();
        }


        public bool IsTheErrorMesssagePresent()
        {
            return IsTheElementVisible(_errorMessage);
        }

        public bool IsTheResetPasswordFormDispalyed()
        {
            return IsTheElementVisible(_resetBtnk);
        }
    }

   
}
