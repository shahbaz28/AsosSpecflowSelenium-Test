using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AsosAutomationTest.PageObjects
{
    public class HomePage
    {
        public IWebElement searchBox
        {
            get { return Constants.driver.FindElement(By.XPath("//*[@id='txtSearch']")); }
        }

        public IWebElement countryPicker
        {
            get
            {
                return Constants.driver.FindElement(By.XPath("//*[@id='localisationMenu']/a"));
            }
        }
        public Actions webPageActions = new Actions(Constants.driver);

        public IWebElement australianOption;

        public void FindAustralianOption()
        {
            australianOption = Constants.driver.FindElement(By.XPath("//*[@id='siteSelectorList']/ul/li[6]/a"));
        }
    }
}
