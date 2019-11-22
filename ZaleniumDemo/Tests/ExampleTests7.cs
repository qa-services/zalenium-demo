using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using ZaleniumDemo.Pages;

namespace ZaleniumDemo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ExampleTests7 : BaseTest
    {

        [Test]
        public void MultiSelectTest()
        {
            var state = "Ohio";
            new SelectDropdownPage(Driver)
                .SelectStates(state)
                .GetFirstSelectedOption()
                .AssertSelectedStatesMessage($"First selected option is : {state}")
                .GetAllSelectedOptions()
                .AssertSelectedStatesMessage($"Options selected are : {state}");

            Thread.Sleep(10000);
        }
    }
}