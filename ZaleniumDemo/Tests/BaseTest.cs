using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace ZaleniumDemo.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddAdditionalCapability("zal:name", TestContext.CurrentContext.Test.MethodName, true);
            options.AddAdditionalCapability("zal:build", $"Test run on {DateTime.Now:f}", true);
            options.AddAdditionalCapability("zal:screenResolution", "1920x1080", true);
            options.AddAdditionalCapability("zal:recordVideo", true, true);
            Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            var cookie = new Cookie("zaleniumTestPassed", (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed).ToString());
            Driver.Manage().Cookies.AddCookie(cookie);
            Driver.Quit();
        }
    }
}