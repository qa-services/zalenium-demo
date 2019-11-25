using FluentAssertions;
using OpenQA.Selenium;

namespace ZaleniumDemo.Pages
{
    public class LoginPage : BasePage
    {
        public override string Url => "https://parabank.parasoft.com/parabank/login.htm";

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement TxtUserName => Driver.FindElement(By.CssSelector("input[name=username]"));
        private IWebElement TxtPassword => Driver.FindElement(By.CssSelector("input[name=password]"));
        private IWebElement BtnLogin => Driver.FindElement(By.CssSelector("input[type=submit]"));
        private IWebElement LnkRegister => Driver.FindElement(By.LinkText("Register"));
        private IWebElement ElmError => Driver.FindElement(By.CssSelector("p.error"));


        public LoginPage LoginWithFailure(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(userName);
            BtnLogin.Click();
            return this;
        }

        public HomePage Login(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(userName);
            BtnLogin.Click();
            return new HomePage(Driver);
        }
        public RegisterPage GoToRegisterPage()
        {
            LnkRegister.Click();
            return new RegisterPage(Driver);
        }

        public LoginPage AssertErrorMessage(string expError)
        {
            ElmError.Displayed.Should().BeTrue();
            ElmError.Text.Should().BeEquivalentTo(expError);
            return this;
        }
    }
}
