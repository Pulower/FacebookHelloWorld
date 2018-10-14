using FacebookHelloWorld.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookHelloWorld.Utils
{
    class WebElementManipulator 
    {
        public WebDriverWait wait = new WebDriverWait(BaseTest.driver, TimeSpan.FromSeconds(20));

        public void ClickOnElement(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public void SendText(IWebElement element, string text)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.SendKeys(text);
        }

        public void waitForClickabiity(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

    }
}
