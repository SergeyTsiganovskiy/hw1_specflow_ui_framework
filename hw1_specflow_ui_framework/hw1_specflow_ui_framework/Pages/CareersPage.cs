using OpenQA.Selenium;

namespace hw1_specflow_ui_framework.Pages
{
    class CareersPage : BasePage
    {
        public CareersPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static CareersPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(BASE_PAGE + "/careers");

            return new CareersPage(driver);
        }
    }
}
