﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class CheckBox : WebElement
    {
        private readonly IWebDriver _driver;
        private readonly By _by;

        public CheckBox(IWebDriver driver, By by) : base(by)
        {
            _driver = driver;
            _by = by;
        }
    }
}
