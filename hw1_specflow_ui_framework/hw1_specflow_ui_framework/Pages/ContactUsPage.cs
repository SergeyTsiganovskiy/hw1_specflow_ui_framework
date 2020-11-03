using OpenQA.Selenium;

namespace hw1_specflow_ui_framework.Pages
{
    class ContactUsPage : BasePage
    {
        public ContactUsPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static ContactUsPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(BASE_PAGE + "/about/who-we-are/contact");

            return new ContactUsPage(driver);
        }
    }
}
