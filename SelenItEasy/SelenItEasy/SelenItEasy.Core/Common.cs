using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelenItEasy.Core.WebElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SelenItEasy.Core
{
    public static class Main
    {
        [ThreadStatic]
        private static EasyDriver _easyDriver;

        public static EasyDriver Open(string url)
        {
            WebDriverManager.GetDriver().Navigate().GoToUrl(url);
            return _easyDriver;
        }

        public static EasyDriver StartChrome()
        {
            _easyDriver = new EasyDriver(Browser.Chrome);
            return _easyDriver;
        }

        public static EasyDriver StartBrowser(IWebDriver driver)
        {
            _easyDriver = new EasyDriver(driver);
            return _easyDriver;
        }

        public static EasyDriver CurrentBrowser()
        {
            return _easyDriver;
        }

        public static Link Link(By by)
        {
            return new Link(by);
        }

        public static Link Link(By by, IWebDriver driver)
        {
            return new Link(by, driver);
        }

        public static List<Link> Links(By by)
        {
            return GetCollection<Link>(by, WebDriverManager.GetDriver());
        }

        public static List<Link> Links(By by, IWebDriver driver)
        {
            return GetCollection<Link>(by, driver);
        }

        public static HtmlElement HtmlElement(By by)
        {
            return new HtmlElement(by);
        }

        private static List<T> GetCollection<T>(By by, IWebDriver driver) where T : EasyElement<T>
        {
            var linkCollection = new List<T>();

            var webElemetnCollection = driver.FindElements(by).ToList();

            foreach (var webElement in webElemetnCollection)
            {
                linkCollection.Add((T)Activator.CreateInstance(typeof(T), webElement));
            }

            return linkCollection;
        }

        public static CheckBox CheckBox(By by)
        {
            return new CheckBox(by);
        }
    }
}
