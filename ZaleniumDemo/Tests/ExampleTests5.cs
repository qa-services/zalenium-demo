using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests5 : BaseTest
    {

        [Test]
        public void MultipleCheckboxTest2()
        {
            var message = Faker.Company.BS();
            new CheckboxPage(Driver)
                .CheckAll()
                .UncheckOneCheckbox()
                .AssertTextOnCheckAllButton("Check All");

            Thread.Sleep(10000);
        }
    }
}