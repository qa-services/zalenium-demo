using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class _depricated_ExampleTests2 : BaseTest
    {

        [Test]
        public void LoginTestNegative()
        {
            new LoginPage(Driver)
                .LoginWithFailure("", "")
                .AssertErrorMessage("Please enter a username and password.");

            Thread.Sleep(10000);
        }
    }
}