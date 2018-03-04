using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenItEasy.Core
{
    // TODO: change to internal
    public class DriverManager
    {
        public static IWebDriver GetDriver()
        {
            if (DriverStorage.Driver == null)
            {
                throw new Exception("Browser is not started");
            }

            return DriverStorage.Driver;
        }

        public static void SetDriver(IWebDriver driver)
        {
            DriverStorage.Driver = driver;
        }

        public static EasyDriver GetNewEasyDriver(Browser browser)
        {
            string pathToChromeDriver = @"G:\";
            //string pathToChromeDriver = Directory.GetCurrentDirectory();

            if (browser == Browser.Chrome)
                return new EasyDriver(new ChromeDriver(pathToChromeDriver));

            throw new Exception();
        }
    }
}
