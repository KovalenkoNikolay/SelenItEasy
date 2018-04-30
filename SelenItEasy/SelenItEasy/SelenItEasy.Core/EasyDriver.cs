using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenItEasy.Core
{
    public class EasyDriver
    {
        public IWebDriver WebDriver => WebDriverManager.GetDriver();
        public string Title => WebDriverManager.GetDriver().Title;
        public string WindowHandle => WebDriverManager.GetDriver().CurrentWindowHandle;
        public string PageSource => WebDriverManager.GetDriver().PageSource;
        public string Url => WebDriverManager.GetDriver().Url;
        public List<string> WindowHandles => WebDriverManager.GetDriver().WindowHandles.ToList();

        public Point Position {
            get
            {
                return WebDriverManager.GetDriver().Manage().Window.Position;
            }
            set
            {
                WebDriverManager.GetDriver().Manage().Window.Position = value;
            }
        }

        public Size Size
        {
            get
            {
                return WebDriverManager.GetDriver().Manage().Window.Size;
            }
            set
            {
                WebDriverManager.GetDriver().Manage().Window.Size = value;
            }
        }

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
        
        /// <summary>
        /// The same as press F11 in browser.
        /// </summary>
        public void SetToFullScreen()
        {
            WebDriverManager.GetDriver().Manage().Window.FullScreen();
        }

        /// <summary>
        /// Set max size of browser. Title bar is displayed.
        /// </summary>
        public void SetToMaxSize()
        {
            WebDriverManager.GetDriver().Manage().Window.Maximize();
        }

        /// <summary>
        /// Minimizes the current window if it is not already maximized.
        /// </summary>
        public void SetToMinSize()
        {
            WebDriverManager.GetDriver().Manage().Window.Minimize();
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
