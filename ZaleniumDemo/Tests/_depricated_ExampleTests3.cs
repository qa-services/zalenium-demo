using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class _depricated_ExampleTests3 : BaseTest
    {

        [Test]
        public void _dep_NavigateToAdminPage()
        {
            Driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            Driver.FindElement(By.LinkText("Admin Page")).Click();
            Assert.True(Driver.Url.Contains("https://parabank.parasoft.com/parabank/admin.htm"));
            Thread.Sleep(10000);
        }
    }
}