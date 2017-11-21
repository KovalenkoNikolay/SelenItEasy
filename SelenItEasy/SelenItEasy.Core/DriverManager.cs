﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OpenQA.Selenium;

namespace SelenItEasy.Core
{
    internal class DriverManager
    {
        public static IWebDriver GetDriver()
        {
            if (DriverStorage.StaticDriver == null) throw new Exception("Driver is not set");

            return DriverStorage.StaticDriver;

            //return Kernel.Instance.Get<DriverStorage>().Driver;
        }

        public static void SetDriver(IWebDriver driver)
        {
            DriverStorage.StaticDriver = driver;

            //Kernel.Instance.Get<DriverStorage>().Driver = driver;
        }
    }
}
