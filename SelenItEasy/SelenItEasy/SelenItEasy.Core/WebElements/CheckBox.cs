using System;
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
        public bool Selected => base._webElement.Selected;

        public CheckBox(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public CheckBox(By by) : base(by) { }

        public CheckBox(By by, IWebDriver driver) : base(by, driver) { }
    }
}
