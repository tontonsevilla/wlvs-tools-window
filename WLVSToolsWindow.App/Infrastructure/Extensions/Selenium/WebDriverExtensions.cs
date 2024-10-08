using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace WLVSToolsWindow.App.Infrastructure.Extensions.Selenium
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static IWebElement FindElementClickable(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }

        public static bool IsElementNotVisible(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        public static IWebElement ElementVisible(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            IWebElement element = null;

            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            }
            catch
            {
                throw;
            }

            return element;
        }

        public static void SendKeysCustom(this IWebElement element, string value)
        {
            element.Click();
            element.Clear();
            element.SendKeys(value);
        }

        private static void TakeScreenShot(IWebDriver driver, string description)
        {
            var screenshotFolder = "Screenshot";
            var screenshotFolderPath = @$"{System.IO.Path.GetDirectoryName(Application.ExecutablePath)}\{screenshotFolder}";

            if (!Directory.Exists(screenshotFolderPath))
            {
                Directory.CreateDirectory(screenshotFolderPath);
            }

            Screenshot screenshot = OpenQA.Selenium.Support.Extensions.WebDriverExtensions.TakeScreenshot(driver);
            screenshot.SaveAsFile(@$"{screenshotFolder}\SS_Error_{description}_{DateTime.Now.ToString("yyyyMMddhhmmss")}.png");
        }

        public static void ScrollToBottom(this IWebDriver driver)
        {
            var js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
        }

        public static void WaitForAjax(this IWebDriver driver, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            wait.Until((d) => {
                var js = driver as IJavaScriptExecutor;
                return (bool) js.ExecuteScript("return jQuery.active == 0");
            });
        }
    }
}
