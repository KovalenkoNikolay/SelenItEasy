using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SelenItEasy.Core
{
    public class Browser
    {
        public Browser() { }

        public Browser(IWebDriver driver)
        {
            DriverManager.SetDriver(driver);
        }

        public void Open(string url)
        {
            DriverManager.GetDriver().Navigate().GoToUrl(url);
        }

        public Browser GetNewChrome()
        {
            DriverManager.SetDriver(new ChromeDriver());
            return this;
        }

        public Browser GetNewFireFox()
        {
            DriverManager.SetDriver(new FirefoxDriver());
            return this;
        }

        /// <summary>
        /// Close browser with all open tabs
        /// </summary>
        public void Close()
        {
            DriverManager.GetDriver().Quit();
        }

        /// <summary>
        /// Close current tab and close browser if only one tab is opened
        /// </summary>
        public void CloseTab()
        {
            DriverManager.GetDriver().Close();
        }
    }
}
