using NUnit.Framework;
using System.Threading;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests3 : BaseTest
    {

        [Test]
        public void SingleCheckboxTest()
        {
            new CheckboxPage(Driver)
                .CheckAge()
                .AssertCheckboxMessageIsShown("Success - Check box is checked");

            Thread.Sleep(10000);
        }
    }
}