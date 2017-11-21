using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class DropDown : WebElement
    {
        public DropDown(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public DropDown(By by) : base(by) { }

        public DropDown(By by, IWebDriver driver) : base(by, driver) { }
    }
}
