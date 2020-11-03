using OpenQA.Selenium;

namespace hw1_specflow_ui_framework.Pages
{
    class WhatWeDoPage : BasePage
    {
        public WhatWeDoPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static WhatWeDoPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(BASE_PAGE + "/what-we-do");

            return new WhatWeDoPage(driver);
        }
    }
}
