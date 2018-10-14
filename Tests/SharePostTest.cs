using FacebookHelloWorld.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookHelloWorld.Tests
{
    
    class SharePostTest : BaseTest
    {
  
        [TestCase("fortest6541@gmail.com", "kowalski123", "Hello world", "Przed chwilą")]
        public void sharePostTest(string login, string password, string message, string time)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.GoToHomePage()
                     .SetLoginAndPassword(login, password)
                     .ClickLogIn()
                     .ClickOnStatusField()
                     .SendTextIntoStatusField(message)
                     .ClickOnShareButton()
                     .AssertThatPostTimeIsRightNow(time)
                     .AssertThatPostIs(message);
        }

    }
    
}
