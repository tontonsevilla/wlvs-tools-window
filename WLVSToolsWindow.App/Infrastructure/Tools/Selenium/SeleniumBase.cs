using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WLVSToolsWindow.App.Infrastructure.Tools.Selenium
{
    internal abstract class SeleniumBase
    {
        public IWebDriver Navigate(string url)
        {
            IWebDriver driver = null;
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(@"C:\Selenium\Chrome\WebDriver");
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddArguments("--incognito");
            chromeOptions.AddExtension(@"C:\Selenium\Chrome\Extensions\AdBlock_6.9.2.0.crx");
            chromeOptions.AddArguments("headless");
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;

            driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Navigate().GoToUrl(url);

            return driver;
        }
    }
}
