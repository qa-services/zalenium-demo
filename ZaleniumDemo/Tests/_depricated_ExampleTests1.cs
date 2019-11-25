using NUnit.Framework;
using System.Threading;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class _depricated_ExampleTests1 : BaseTest
    {
        [Test]
        public void _dep_LoginTest()
        {
            new LoginPage(Driver)
                .Login("zalenium_demo", "P@ssword")
                .AssertLogoutLinkIsShown();

            Thread.Sleep(10000);
        }

        [Test]
        public void _dep_RegisterTest()
        {
            new LoginPage(Driver)
                .GoToRegisterPage()
                .Register()
                .AssertLogoutLinkIsShown();

            Thread.Sleep(10000);
        }
    }
}