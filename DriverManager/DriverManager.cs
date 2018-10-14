using FacebookHelloWorld.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookHelloWorld.DriverManager
{
    class DriverManager
    {
        public static IWebDriver getDriver(DriverType type)
        {
            switch (type)
            {
                case DriverType.CHROME:
                    {
                        ChromeOptions options = new ChromeOptions();
                        options.AddArguments("--disable-notifications");
                        Environment.SetEnvironmentVariable("webdriver.chrome.driver", "");
                        BaseTest.driver = new ChromeDriver(options);
                        break;
                    }
                case DriverType.FIREFOX:
                    {
                        FirefoxOptions options = new FirefoxOptions();
                        options.SetPreference("dom.webnotifications.enabled", false);
                        BaseTest.driver = new FirefoxDriver(options);
                        break;
                    }
                default:
                    {
                        InternetExplorerOptions options = new InternetExplorerOptions { EnsureCleanSession = true };
                        BaseTest.driver = new InternetExplorerDriver(options);
                        break;
                    }
            }
            BaseTest.driver.Manage().Cookies.DeleteAllCookies();
            BaseTest.driver.Manage().Window.Maximize();
            return BaseTest.driver;
        }
    }
}
