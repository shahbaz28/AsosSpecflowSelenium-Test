using OpenQA.Selenium;


namespace AsosAutomationTest.PageObjects
{
    public class SearchResultsPage
    {
        public IWebElement searchTerm = Constants.driver.FindElement(By.XPath("//*[@id='productlist-results']/div/div[2]/h1"));
        public IWebElement SortFourColumns
        {
            get
            {
                return Constants.driver.FindElement(By.XPath("//*[@id='productlist-results']/div/div[3]/p[2]/a[2]"));
            }
        }
        public string PageSource
        {
            get
            {

                return Constants.driver.PageSource;
            }

        }
        public IWebElement femaleSelection
        {
            get
            {
                return Constants.driver.FindElement(By.XPath("//*[@id='productlist-results']/aside/div[1]/div/div/ul/li[2]/a/span[2]"));
            }
        }
        public IWebElement femaleCheckBox
        {
            get
            {
                return Constants.driver.FindElement(By.XPath("//*[@id='productlist-results']/aside/div[1]/div/div/ul/li[2]/a/span[1]"));

            }
        }
        public IWebElement womenCheckBox
        {
            get
            {
                return Constants.driver.FindElement(By.XPath("//*[@id='productlist-results']/aside/div[1]/div/div/ul/li[2]/a/span[1]"));
            }
        }
    }
}

