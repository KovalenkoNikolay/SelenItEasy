using System;
using OpenQA.Selenium;

namespace SelenItEasy.Core
{
    internal class DriverStorage
    {
        [ThreadStatic]
        private static IWebDriver staticDriver;

        public static IWebDriver Driver
        {
            get { return staticDriver; }
            set { staticDriver = value; }
        }
    }
}
