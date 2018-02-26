using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelenItEasy.Core.WebElements;

namespace SelenItEasy.Core
{
    public static class Main
    {
        [ThreadStatic]
        private static Browser _browser;

        public static Browser StartChrome()
        {
            _browser = new Browser(new ChromeDriver(Directory.GetCurrentDirectory()));
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

        #region Link

        public static Link Link(By by)
        {
            return new Link(by);
        }

        public static Link Link(By by, IWebDriver driver)
        {
            return new Link(by, driver);
        }

        public static List<Link> LinkCollection(By by)
        {
            return GetCollection<Link>(by, DriverManager.GetDriver());
        }

        public static List<Link> LinkCollection(By by, IWebDriver driver)
        {
            return GetCollection<Link>(by, driver);
        }

        #endregion

        public static HtmlElement HtmlElement(By by)
        {
            return new HtmlElement(by);
        }

        #endregion

        private static List<T> GetCollection<T>(By by, IWebDriver driver) where T : WebElement
        {
            var linkCollection = new List<T>();

            var webElemetnCollection = driver.FindElements(by).ToList();

            foreach (var webElement in webElemetnCollection)
            {
                linkCollection.Add((T)Activator.CreateInstance(typeof(T), webElement));
            }

            return linkCollection;
        }
    }
}
