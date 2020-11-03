using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace hw1_specflow_ui_framework.Pages
{
    class AboutPage : BasePage
    {
        public AboutPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static AboutPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(BASE_PAGE + "/about");

            return new AboutPage(driver);
        }
    }
}
