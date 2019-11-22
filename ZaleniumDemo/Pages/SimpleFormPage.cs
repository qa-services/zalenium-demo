using FluentAssertions;
using OpenQA.Selenium;

namespace ZaleniumDemo.Pages
{
    class SimpleFormPage : BasePage
    {
        public override string Url => "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

        public SimpleFormPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement TxtMessage => Driver.FindElement(By.CssSelector("#user-message"));
        private IWebElement BtnShowMessage => Driver.FindElement(By.XPath("//button[text()='Show Message']"));
        private IWebElement ElmMessage => Driver.FindElement(By.CssSelector("#display"));
        private IWebElement TxtSum1 => Driver.FindElement(By.CssSelector("#sum1"));
        private IWebElement TxtSum2 => Driver.FindElement(By.CssSelector("#sum2"));
        private IWebElement BtnGetTotal => Driver.FindElement(By.XPath("//button[text()='Get Total']"));
        private IWebElement ElmSum => Driver.FindElement(By.CssSelector("#displayvalue"));

        public SimpleFormPage TypeMessage(string message)
        {
            TxtMessage.SendKeys(message);
            return this;
        }

        public SimpleFormPage ShowMessage()
        {
            BtnShowMessage.Click();
            return this;
        }

        public SimpleFormPage TypeSum1(string value)
        {
            TxtSum1.SendKeys(value);
            return this;
        }

        public SimpleFormPage TypeSum2(string value)
        {
            TxtSum2.SendKeys(value);
            return this;
        }

        public SimpleFormPage GetTotal()
        {
            BtnGetTotal.Click();
            return this;
        }

        public SimpleFormPage AssertMessageIsShown(string expMessage)
        {
            ElmMessage.Displayed.Should().BeTrue();
            ElmMessage.Text.Should().BeEquivalentTo(expMessage);
            return this;
        }

        public SimpleFormPage AssertSumIsCorrect(string expSum)
        {
            ElmSum.Displayed.Should().BeTrue();
            ElmSum.Text.Should().BeEquivalentTo(expSum);
            return this;
        }
    }
}
