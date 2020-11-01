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
    public abstract class BasePage
    {
        private IWebDriver _driver;

        public BasePage(DriverManagement driver)
        {
            _driver = driver.GetWebDriver();
        }

        protected IWebElement GetWebElement(By locator, double timeout = 30)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            return _driver.FindElement(locator);
        }

        protected bool IsTheElementVisible(By locator, double timeout = 30)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch
            {
                return false;

            }

        }


    }
}
