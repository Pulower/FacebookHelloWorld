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
    class LoginPage : WebElementManipulator
    {

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "loginbutton")]
        private IWebElement LoginButton { get; set; }

        public LoginPage GoToHomePage()
        {
            BaseTest.driver.Navigate().GoToUrl("http://www.facebook.com");
            return this;
        }

        public LoginPage SetLoginAndPassword(string login, string pass)
        {
            SendText(Email, login);
            SendText(Password, pass);
            return this;
        }

        public HomePage ClickLogIn()
        {
            ClickOnElement(LoginButton);
            wait.Until(ExpectedConditions.TitleIs("Facebook"));
            Assert.AreEqual("Facebook", BaseTest.driver.Title);
            return new HomePage(BaseTest.driver);
        }
    }
}
