using AsosAutomationTest.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AsosAutomationTest
{
    [Binding]
    public class AsosSpecflowSteps
    {
        HomePage _homePage;

        [BeforeScenario]
        public void Setup()
        {

            Constants.DriverInitialiser();

            Constants.driver.Navigate().GoToUrl("http://www.asos.com");

        }
        [AfterScenario]
        public void TearDown()
        {
            Constants.driver.Close();
        }


        [Given(@"I want to order a shirt")]
        public void GivenIWantToOrderAShirt()
        {
            _homePage = new HomePage();


        }
        [When(@"i search for purple t shirts")]
        public void WhenISearchForPurpleTShirts()
        {
            _homePage.searchBox.SendKeys("purple t shirt");
            _homePage.searchBox.SendKeys(Keys.Enter);
        }

        [Then(@"I should see some purple t shirts")]
        public void ThenIShouldSeeSomePurpleTShirts()
        {
            SearchResultsPage _searchResultsPage = new SearchResultsPage();

            string actualText = _searchResultsPage.searchTerm.Text;
            Assert.AreEqual("Purple T Shirt", actualText);
        }

        [When(@"I search for yellow t shirts in the Australian store")]
        public void WhenISearchForYellowTShirtsInTheAustralianStore()
        {
            _homePage.countryPicker.Click();
            _homePage.webPageActions.MoveToElement(_homePage.countryPicker);
            _homePage.FindAustralianOption();
            _homePage.webPageActions.MoveToElement(_homePage.australianOption);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Constants.driver;
            js.ExecuteScript("arguments[0].click()", _homePage.australianOption);
            _homePage.searchBox.SendKeys("yellow t shirt");
            _homePage.searchBox.SendKeys(Keys.Enter);


        }

        [Then(@"I should see some yellow t shirts")]
        public void ThenIShouldSeeSomeYellowTShirts()
        {
            SearchResultsPage _searchResultsPage = new SearchResultsPage();

            string actualText = _searchResultsPage.searchTerm.Text;
            Assert.AreEqual("Yellow T Shirt", actualText);
        }

        [When(@"I organize them in four columns")]
        public void WhenIOrganizeThemInFourColumns()
        {
            SearchResultsPage _searchResultsPage = new SearchResultsPage();
            _searchResultsPage.SortFourColumns.Click();

        }

        [Then(@"I should see some yellow t shirts organized in (.*) columns")]
        public void ThenIShouldSeeSomeYellowTShirtsOrganizedInColumns(int p0)
        {
            SearchResultsPage _searchResultsPage = new SearchResultsPage();
            bool ResultsFour = _searchResultsPage.PageSource.Contains("results four-grid");
            Assert.IsTrue(ResultsFour);
        }
        [When(@"I filetr to female")]
        public void WhenIFiletrToFemale()
        {
            SearchResultsPage _searchResultsPage = new SearchResultsPage();
            _searchResultsPage.femaleSelection.Click();
        }
        [Then(@"I see t shirts for female")]
        public void ThenISeeTShirtsForFemale()
        {
            SearchResultsPage _searchResultsPage = new SearchResultsPage();
            Assert.IsTrue(_searchResultsPage.womenCheckBox.Text == "ticked");
        }

    }
}
