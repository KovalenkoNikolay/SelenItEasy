using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace SelenItEasy.Core
{
    public class EasyDriver
    {
        internal EasyDriver(IWebDriver driver)
        {
            DriverManager.SetDriver(driver);
        }

        public IWebDriver GetDriver()
        {
            return DriverManager.GetDriver();
        }

        public EasyDriver Open(string url)
        {
            DriverManager.GetDriver().Navigate().GoToUrl(url);
            return this;
        }

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

        public EasyDriver GoBack()
        {
            DriverManager.GetDriver().Navigate().Back();
            return this;
        }

        public EasyDriver Refresh()
        {
            DriverManager.GetDriver().Navigate().Refresh();
            return this;
        }

        public EasyDriver GoForward()
        {
            DriverManager.GetDriver().Navigate().Forward();
            return this;
        }
    }
}
