using System;
using OpenQA.Selenium;

namespace SelenItEasy.Core
{
    // TODO: change to internal
    public class WebDriverManager
    {
        public static IWebDriver GetDriver()
        {
            if (WebDriverStorage.Driver == null)
            {
                throw new Exception("Browser is not started");
            }

            return WebDriverStorage.Driver;
        }

        public static void StoreDriver(IWebDriver driver)
        {
            WebDriverStorage.Driver = driver;
        }
    }
}
