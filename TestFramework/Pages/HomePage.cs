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
    public class HomePage: BasePage
    {
        //private IWebDriver _driver;


        protected readonly By _homeMenu = By.XPath("//div[contains(@class, 'hui-globalnav__group')]");

        public HomePage(DriverManagement driver) : base (driver)
        {
            //_driver = driver;
        }

        private IWebElement HomeMenu
        {
            get { return GetWebElement(_homeMenu); }
        }

        public bool IsHomePageDisplayed()
        {
            return IsTheElementVisible(_homeMenu);
        }


    }
}
