using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class RadioButton : WebElement
    {
        public RadioButton(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public RadioButton(By by) : base(by) { }

        public RadioButton(By by, IWebDriver driver) : base(by, driver) { }
    }
}
