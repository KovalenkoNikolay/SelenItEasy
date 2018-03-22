using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core
{
    public class EasyDriver
    {
        internal EasyDriver(Browser browser)
        {
            var driverService = DriverServiceManager.Start(browser);

            DriverOptions options;

            switch (browser)
            {
                case Browser.Chrome:
                    options = new ChromeOptions();
                    break;
                case Browser.FireFox:
                    options = new ChromeOptions();
                    break;
                default:
                    // TODO: Exception
                    throw new Exception();
            }

            //options.BinaryLocation = pathToChromeDriver;
            var driver = RemoteWebDriverManager.GetNew(options);

            WebDriverManager.StoreDriver(driver);
        }

        internal EasyDriver(IWebDriver driver)
        {
            WebDriverManager.StoreDriver(driver);
        }

        public IWebDriver GetWebDriver()
        {
            return WebDriverManager.GetDriver();
        }

        public EasyDriver Open(string url)
        {
            WebDriverManager.GetDriver().Navigate().GoToUrl(url);
            return this;
        }

        /// <summary>
        /// Close browser with all open tabs
        /// </summary>
        public void Quit()
        {
            WebDriverManager.GetDriver().Quit();

            DriverServiceManager.Stop();
        }

        /// <summary>
        /// Close current tab and close browser if only one tab is opened
        /// </summary>
        public void CloseTab()
        {
            WebDriverManager.GetDriver().Close();
        }

        public string GetTitle()
        {
            return WebDriverManager.GetDriver().Title;
        }

        public string GetWindowHandle()
        {
            return WebDriverManager.GetDriver().CurrentWindowHandle;
        }

        public string GetPageSource()
        {
            return WebDriverManager.GetDriver().PageSource;
        }

        public string GetUrl()
        {
            return WebDriverManager.GetDriver().Url;
        }

        public List<string> GetWindowHandles()
        {
            return WebDriverManager.GetDriver().WindowHandles.ToList();
        }

        public IOptions Manage()
        {
            return WebDriverManager.GetDriver().Manage();
        }

        public ITargetLocator SwitchTo()
        {
            return WebDriverManager.GetDriver().SwitchTo();
        }

        public EasyDriver GoBack()
        {
            WebDriverManager.GetDriver().Navigate().Back();
            return this;
        }

        public EasyDriver Refresh()
        {
            WebDriverManager.GetDriver().Navigate().Refresh();
            return this;
        }

        public EasyDriver GoForward()
        {
            WebDriverManager.GetDriver().Navigate().Forward();
            return this;
        }
    }
}
