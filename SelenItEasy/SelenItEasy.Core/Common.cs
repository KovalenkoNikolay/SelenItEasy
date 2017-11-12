using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelenItEasy.Core.WebElements;

namespace SelenItEasy.Core
{
    public static class Common
    {
        [ThreadStatic]
        public static Browser _browser;

        public static Browser StartChrome()
        {
            _browser = new Browser(new ChromeDriver());
            return _browser;
        }

        public static Browser StartBrowser(IWebDriver driver)
        {
            _browser = new Browser(driver);
            return _browser;
        }

        public static Browser CurrentBrowser()
        {
            return _browser;
        }

        #region Elements

        public static Link Link(By by)
        {
            return new Link(by);
        }

        public static Link Link(By by, IWebDriver driver)
        {
            return new Link(by, driver);
        }

        #endregion
    }
}
