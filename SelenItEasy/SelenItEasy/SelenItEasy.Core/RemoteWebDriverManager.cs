using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace SelenItEasy.Core
{
    public class RemoteWebDriverManager
    {
        [ThreadStatic]
        private static RemoteWebDriver _driver;

        public static RemoteWebDriver GetNew(DriverOptions driverOptions, string uri = null)
        {
            if (uri == null)
                uri = $"http://127.0.0.1:{DriverServiceManager.Get().Port}";

            _driver = new RemoteWebDriver(new Uri(uri), driverOptions);
            return _driver;
        }
    }
}
