using hw1_specflow_ui_framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace hw1_specflow_ui_framework.Tests
{
    [Binding]
    public class OfficialSiteMainPageSteps
    {
        private IWebDriver _driver;
        private MainPage _mainPage;

        [Given(@"Browser is opened")]
        public void GivenBrowserIsOpened()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }
        
        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {

        }
        
        [Given(@"I am on the loan application screen")]
        public void GivenIAmOnTheLoanApplicationScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I navigate to the main page")]
        public void WhenINavigateToTheMainPage()
        {
            _mainPage = MainPage.NavigateTo(_driver);
        }
        
        [When(@"I navigate each inner chapter")]
        public void WhenINavigateEachInnerChapter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click '(.*)' button")]
        public void WhenIClickButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the right title in browser'(.*)'s logo in header")]
        public void ThenIShouldSeeTheRightTitleInBrowserSLogoInHeader(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on right page and see correct header")]
        public void ThenIShouldBeOnRightPageAndSeeCorrectHeader()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on right page and see correct contact info")]
        public void ThenIShouldBeOnRightPageAndSeeCorrectContactInfo()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
