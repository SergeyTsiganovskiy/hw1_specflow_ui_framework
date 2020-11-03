using OpenQA.Selenium;

namespace hw1_specflow_ui_framework.Pages
{
    class InsightsPage : BasePage
    {
        public InsightsPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static InsightsPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(BASE_PAGE + "/insights");

            return new InsightsPage(driver);
        }
    }
}
