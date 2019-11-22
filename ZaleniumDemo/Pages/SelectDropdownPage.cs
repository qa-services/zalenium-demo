using FluentAssertions;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace ZaleniumDemo.Pages
{
    class SelectDropdownPage : BasePage
    {
        public override string Url => "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";

        public SelectDropdownPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement SlcDay => Driver.FindElement(By.CssSelector("#select-demo"));
        private IWebElement ElmSelectedMessage => Driver.FindElement(By.CssSelector(".selected-value"));
        private IWebElement SlcState => Driver.FindElement(By.CssSelector("#multi-select"));
        private IWebElement BtnFirstSelected => Driver.FindElement(By.CssSelector("#printMe"));
        private IWebElement BtnAllSelected => Driver.FindElement(By.CssSelector("#printAll"));
        private IWebElement ElmMutliSelectedMessage => Driver.FindElement(By.CssSelector(".getall-selected"));

        public SelectDropdownPage SelectDay(string day)
        {
            new SelectElement(SlcDay).SelectByText(day);
            return this;
        }

        public SelectDropdownPage SelectStates(params string[] states)
        {
            var selectElement = new SelectElement(SlcState);
            foreach (var state in states)
            {
                selectElement.SelectByText(state);
            }
            return this;
        }

        public SelectDropdownPage GetFirstSelectedOption()
        {
            BtnFirstSelected.Click();
            return this;
        }

        public SelectDropdownPage GetAllSelectedOptions()
        {
            BtnAllSelected.Click();
            return this;
        }

        public SelectDropdownPage AssertSelectedDayMessage(string expMessage)
        {
            ElmSelectedMessage.Displayed.Should().BeTrue();
            ElmSelectedMessage.Text.Should().BeEquivalentTo(expMessage);
            return this;
        }

        public SelectDropdownPage AssertSelectedStatesMessage(string expText)
        {
            ElmMutliSelectedMessage.Text.Should().BeEquivalentTo(expText);
            return this;
        }
    }
}
