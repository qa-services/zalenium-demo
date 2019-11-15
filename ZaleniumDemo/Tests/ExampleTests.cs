using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests : BaseTest
    {
        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            Driver.FindElement(By.CssSelector("input[name=username]")).SendKeys("zalenium_demo");
            Driver.FindElement(By.CssSelector("input[name=password]")).SendKeys("P@ssword");
            Driver.FindElement(By.CssSelector("input[type=submit]")).Click();
            Assert.True(Driver.FindElement(By.LinkText("Log Out")).Displayed);
            Thread.Sleep(10000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ExampleTests2 : BaseTest
    {

        [Test]
        public void LoginTestNegative()
        {
            Driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            Driver.FindElement(By.CssSelector("input[type=submit]")).Click();
            Assert.AreEqual(Driver.FindElement(By.CssSelector("p.error")).Text,
                "Please enter a username and password.");
            Thread.Sleep(10000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ExampleTests3 : BaseTest
    {

        [Test]
        public void NavigateToAdminPage()
        {
            Driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            Driver.FindElement(By.LinkText("Admin Page")).Click();
            Assert.True(Driver.Url.Contains("https://parabank.parasoft.com/parabank/admin.htm"));
            Thread.Sleep(10000);
        }
    }
}