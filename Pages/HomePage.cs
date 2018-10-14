using FacebookHelloWorld.Tests;
using FacebookHelloWorld.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookHelloWorld.Pages
{
    class HomePage : WebElementManipulator
    {

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//textarea")]
        private IWebElement StatusField {get; set;}

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='status-attachment-mentions-input']")]
        private IWebElement StatusTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='react-composer-post-button']")]
        private IWebElement ShareButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-ad-preview='message']/div")]
        private IWebElement PostText { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Przed chwilą")]
        private IWebElement PostTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-ad-preview='message'][1]")]
        private IWebElement MessageContent { get; set; }

        public HomePage ClickOnStatusField()
        {
            ClickOnElement(StatusField);
            return this;
        }

        public HomePage SendTextIntoStatusField(string message)
        {
            SendText(StatusTextField, message);
            return this;
        }

        public HomePage ClickOnShareButton()
        {
            ClickOnElement(ShareButton);
            waitForClickabiity(PostText);
            return this;
        }

        public HomePage AssertThatPostTimeIsRightNow(string time)
        {
            waitForClickabiity(PostTime);
            Assert.AreEqual(time, PostTime.Text);
            return this;
        }

        public HomePage AssertThatPostIs(string post)
        {
            waitForClickabiity(MessageContent);
            Assert.AreEqual(post, MessageContent.Text);
            return this;
        }
    }
    
}
