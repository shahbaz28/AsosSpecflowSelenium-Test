using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AsosAutomationTest
{
    public static class Constants
    {
        public static IWebDriver driver;

        public static void DriverInitialiser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            driver = new ChromeDriver(@".\", options);
        }

    }
}
