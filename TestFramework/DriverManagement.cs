using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class DriverManagement 
    {
        static IWebDriver _driver;

        private DriverManagement(IWebDriver driver)
        {
            _driver = driver;
        }

        static public DriverManagement getDriver(string url)
        {
            
            _driver = new ChromeDriver("C:\\WebDriver");
            _driver.Manage().Window.Maximize();
            _driver.Url = url;
            return new DriverManagement(_driver);
        }


        public IWebDriver GetWebDriver() { return _driver; }

        public void Close()
        {
            _driver.Close();
        }

    }
}
