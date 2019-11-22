using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests1 : BaseTest
    {

        [Test]
        public void SingleInputTest()
        {
            var message = Faker.Company.BS();
            new SimpleFormPage(Driver)
                .TypeMessage(message)
                .ShowMessage()
                .AssertMessageIsShown(message);

            Thread.Sleep(10000);
        }
    }
}