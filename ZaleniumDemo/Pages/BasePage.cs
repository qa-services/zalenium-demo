using OpenQA.Selenium;

namespace ZaleniumDemo.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        public abstract string Url { get; }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Navigate().GoToUrl(Url);
        }
    }
}
