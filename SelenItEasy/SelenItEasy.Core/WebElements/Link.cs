﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class Link : WebElement
    {
        private readonly IWebDriver _driver;
        private readonly By _by;

        public Link(IWebDriver driver, By by) : base(driver, by)
        {
            _driver = Kernel.Instance.Get<Storage>().driver;
            _by = by;
        }

        public void Click()
        {
            _driver.FindElement(_by).Click();
        }
    }
}
