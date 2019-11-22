using OpenQA.Selenium;

namespace ZaleniumDemo.Pages
{
    public class RegisterPage
    {
        protected IWebDriver Driver;

        public RegisterPage(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebElement TxtFirstName => Driver.FindElement(By.Id("customer.firstName"));
        private IWebElement TxtLastName => Driver.FindElement(By.Id("customer.lastName"));
        private IWebElement TxtStreet => Driver.FindElement(By.Id("customer.address.street"));
        private IWebElement TxtCity => Driver.FindElement(By.Id("customer.address.city"));
        private IWebElement TxtState => Driver.FindElement(By.Id("customer.address.state"));
        private IWebElement TxtZipCode => Driver.FindElement(By.Id("customer.address.zipCode"));
        private IWebElement TxtPhoneNumber => Driver.FindElement(By.Id("customer.phoneNumber"));
        private IWebElement TxtSsn => Driver.FindElement(By.Id("customer.ssn"));
        private IWebElement TxtUserName => Driver.FindElement(By.Id("customer.username"));
        private IWebElement TxtPassword => Driver.FindElement(By.Id("customer.password"));
        private IWebElement TxtConfirmPassword => Driver.FindElement(By.Id("repeatedPassword"));
        private IWebElement BtnRegister => Driver.FindElement(By.CssSelector("input[type=submit]"));

        public HomePage Register()
        {
            TxtFirstName.SendKeys(Faker.Name.First());
            TxtLastName.SendKeys(Faker.Name.Last());
            TxtStreet.SendKeys(Faker.Address.StreetName());
            TxtCity.SendKeys(Faker.Address.City());
            TxtState.SendKeys(Faker.Address.UsState());
            TxtZipCode.SendKeys(Faker.Address.ZipCode());
            TxtPhoneNumber.SendKeys(Faker.Phone.Number());
            TxtSsn.SendKeys(Faker.Identification.UKNationalInsuranceNumber());
            TxtUserName.SendKeys(Faker.Internet.UserName());
            TxtPassword.SendKeys("P@ssword");
            TxtConfirmPassword.SendKeys("P@ssword");
            BtnRegister.Click();
            return new HomePage(Driver);
        }
    }
}
