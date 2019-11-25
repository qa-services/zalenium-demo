using FluentAssertions;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ZaleniumDemo.Pages
{
    public class CheckboxPage : BasePage
    {
        public override string Url => "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";

        public CheckboxPage (IWebDriver driver) : base(driver)
        {
        }

        private IWebElement ChkAge => Driver.FindElement(By.CssSelector("#isAgeSelected"));
        private IWebElement ElmMessage => Driver.FindElement(By.CssSelector("#txtAge"));
        private List<IWebElement> CheckboxesList => Driver.FindElements(By.CssSelector(".cb1-element")).ToList();
        private IWebElement BtnCheckAll => Driver.FindElement(By.CssSelector("#check1"));

        public CheckboxPage CheckAge()
        {
           if (!ChkAge.Selected) ChkAge.Click();
            return this;
        }

        public CheckboxPage CheckAll()
        {
            BtnCheckAll.Click();
            return this;
        }

        public CheckboxPage UncheckOneCheckbox()
        {
            var firstCheckbox = CheckboxesList.First();
            if(firstCheckbox.Selected) firstCheckbox.Click();
            return this;
        }

        public CheckboxPage AssertCheckboxMessageIsShown(string expMessage)
        {
            ElmMessage.Displayed.Should().BeTrue();
            ElmMessage.Text.Should().BeEquivalentTo(expMessage);
            return this;
        }

        public CheckboxPage AssertTextOnCheckAllButton(string expText)
        {
            BtnCheckAll.GetAttribute("value").Should().BeEquivalentTo(expText);
            return this;
        }

        public CheckboxPage AssertAllCheckboxesAreChecked()
        {
            CheckboxesList.Should().HaveCount(4);
            CheckboxesList.ForEach(checkbox => checkbox.Selected.Should().BeTrue());
            return this;
        }
    }
}
