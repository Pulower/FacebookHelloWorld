using FacebookHelloWorld.DriverManager;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookHelloWorld.Tests
{
    class BaseTest
    {
        public static IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            DriverManager.DriverManager.getDriver(DriverType.CHROME);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
