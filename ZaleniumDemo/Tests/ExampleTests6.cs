using NUnit.Framework;
using System;
using System.Threading;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests6 : BaseTest
    {

        [Test]
        public void SingleSelectTest()
        {
            string day = DateTime.Today.ToString("dddd");
            new SelectDropdownPage(Driver)
                .SelectDay(day)
                .AssertSelectedDayMessage($"Day selected :- {day}");

            Thread.Sleep(10000);
        }
    }
}