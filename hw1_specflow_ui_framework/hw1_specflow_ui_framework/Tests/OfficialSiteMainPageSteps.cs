using hw1_specflow_ui_framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace hw1_specflow_ui_framework.Tests
{
    [Binding]
    public class OfficialSiteMainPageSteps
    {
        private IWebDriver _driver;

        [Given(@"Browser is opened")]
        public void GivenBrowserIsOpened()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }
        
       
        [When(@"I navigate to the main page")]
        public void WhenINavigateToTheMainPage()
        {
            MainPage.NavigateTo(_driver);
        }
        
       
        [Then(@"I should see the right title in browser'(.*)'s logo in header")]
        public void ThenIShouldSeeTheRightTitleInBrowserSLogoInHeader(string p0)
        {
            Assert.Equal("https://www.epam.com/", _driver.Url);
        }
    }
}
