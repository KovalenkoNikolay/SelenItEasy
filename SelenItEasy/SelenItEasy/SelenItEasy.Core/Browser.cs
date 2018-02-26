using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SelenItEasy.Core
{
    public class Browser
    {
        internal Browser(IWebDriver driver)
        {
            DriverManager.SetDriver(driver);
        }

        public IWebDriver GetDriver()
        {
            return DriverManager.GetDriver();
        }

        public Browser Open(string url)
        {
            DriverManager.GetDriver().Navigate().GoToUrl(url);
            return this;
        }
        
        /// Hello
        /// <summary>
        /// Close browser with all open tabs
        /// </summary>
        public void Quit()
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

        public string GetTitle()
        {
            return DriverManager.GetDriver().Title;
        }

        public string GetWindowHandle()
        {
            return DriverManager.GetDriver().CurrentWindowHandle;
        }

        public string GetPageSource()
        {
            return DriverManager.GetDriver().PageSource;
        }

        public string GetUrl()
        {
            return DriverManager.GetDriver().Url;
        }

        public List<string> GetWindowHandles()
        {
            return DriverManager.GetDriver().WindowHandles.ToList();
        }

        public IOptions Manage()
        {
            return DriverManager.GetDriver().Manage();
        }

        public ITargetLocator SwitchTo()
        {
            return DriverManager.GetDriver().SwitchTo();
        }

        #region Navigation

        public Browser GoBack()
        {
            DriverManager.GetDriver().Navigate().Back();
            return this;
        }

        public Browser Refresh()
        {
            DriverManager.GetDriver().Navigate().Refresh();
            return this;
        }

        public Browser GoForward()
        {
            DriverManager.GetDriver().Navigate().Forward();
            return this;
        }

        #endregion
    }
}
