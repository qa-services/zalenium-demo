using FluentAssertions;
using OpenQA.Selenium;

namespace ZaleniumDemo.Pages
{
    public class HomePage
    {
        protected IWebDriver Driver;

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebElement LnkLogout => Driver.FindElement(By.LinkText("Log Out"));

        public HomePage AssertLogoutLinkIsShown()
        {
            LnkLogout.Displayed.Should().BeTrue();
            return this;
        }
    }
}
