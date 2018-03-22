using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenItEasy.Core
{
    public class DriverServiceManager
    {
        [ThreadStatic]
        private static DriverService _driverService;

        private static string pathToChromeDriver = @"G:\";
        //private static string pathToChromeDriver = Directory.GetCurrentDirectory();

        public static DriverService Start(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    _driverService = ChromeDriverService.CreateDefaultService(pathToChromeDriver);
                    _driverService.Start();
                    return _driverService;
                default:
                    throw new Exception();
            }
        }

        public static DriverService Stop()
        {
            _driverService.Dispose();
            return _driverService;
        }

        public static DriverService Get()
        {
            return _driverService;
        }
    }
}
