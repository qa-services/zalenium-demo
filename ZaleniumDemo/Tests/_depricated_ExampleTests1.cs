using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class _depricated_ExampleTests1 : BaseTest
    {
        [Test]
        public void LoginTest()
        {
            new LoginPage(Driver)
                .Login("zalenium_demo", "P@ssword")
                .AssertLogoutLinkIsShown();

            Thread.Sleep(10000);
        }

        [Test]
        public void RegisterTest()
        {
            new LoginPage(Driver)
                .GoToRegisterPage()
                .Register()
                .AssertLogoutLinkIsShown();

            Thread.Sleep(10000);
        }
    }
}