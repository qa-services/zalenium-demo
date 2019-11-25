using NUnit.Framework;
using System.Threading;
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
            new CheckboxPage(Driver)
                .CheckAll()
                .UncheckOneCheckbox()
                .AssertTextOnCheckAllButton("Check All");

            Thread.Sleep(10000);
        }
    }
}