using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace hw1_specflow_ui_framework.Pages
{
    class BasePage
    {
        protected const string BASE_PAGE = @"https://www.epam.com/";

        public BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        protected internal IWebDriver WebDriver { get; set; }

        protected IWebElement WaitForElementIsVisible(By locator, int timeout = 180)
        {
            return new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeout))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
