using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests2 : BaseTest
    {
        [Test]
        public void SingleTwoInputsTest()
        {
            var message = Faker.Company.BS();
            new SimpleFormPage(Driver)
                .TypeSum1("5")
                .TypeSum2("6")
                .GetTotal()
                .AssertSumIsCorrect("11");

            Thread.Sleep(10000);
        }
    }
}