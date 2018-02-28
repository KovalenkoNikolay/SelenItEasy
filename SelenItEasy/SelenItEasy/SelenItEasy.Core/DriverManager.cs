using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SelenItEasy.Core
{
    internal class DriverManager
    {
        public static IWebDriver GetDriver()
        {
            if (DriverStorage.StaticDriver == null) throw new Exception("Driver is not set");

            return DriverStorage.StaticDriver;
        }

        public static void SetDriver(IWebDriver driver)
        {
            DriverStorage.StaticDriver = driver;
        }
    }
}
