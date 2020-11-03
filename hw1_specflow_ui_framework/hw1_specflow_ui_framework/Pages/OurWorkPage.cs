using OpenQA.Selenium;

namespace hw1_specflow_ui_framework.Pages
{
    class OurWorkPage : BasePage
    {
        public OurWorkPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static OurWorkPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(BASE_PAGE + "/our-work");

            return new OurWorkPage(driver);
        }
    }
}
