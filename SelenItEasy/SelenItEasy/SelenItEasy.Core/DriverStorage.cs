﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenItEasy.Core
{
    internal class DriverStorage
    {
        [ThreadStatic]
        public static IWebDriver StaticDriver;

        public IWebDriver Driver { get; set; }
    }
}
