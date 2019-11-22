using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ZaleniumDemo.Pages
{
    abstract class BasePage
    {
        protected IWebDriver Driver;
        public abstract string Url { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Navigate().GoToUrl(Url);
        }
    }
}
