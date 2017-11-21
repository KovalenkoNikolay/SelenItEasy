using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class Button : WebElement
    {
        public Button(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public Button(By by) : base(by) { }

        public Button(By by, IWebDriver driver) : base(by, driver) { }
    }
}
