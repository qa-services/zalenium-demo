using NUnit.Framework;
using System.Threading;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests4 : BaseTest
    {

        [Test]
        public void MultipleCheckboxTest()
        {
            var message = Faker.Company.BS();
            new CheckboxPage(Driver)
                .CheckAll()
                .AssertAllCheckboxesAreChecked()
                .AssertTextOnCheckAllButton("Uncheck All");

            Thread.Sleep(10000);
        }
    }
}