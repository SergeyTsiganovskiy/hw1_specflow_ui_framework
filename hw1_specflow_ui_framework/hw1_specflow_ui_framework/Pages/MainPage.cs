using OpenQA.Selenium;

namespace hw1_specflow_ui_framework.Pages
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static MainPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(BASE_PAGE);

            return new MainPage(driver);
        }
    }
}
