using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class HtmlElement : WebElement
    {
        public HtmlElement(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public HtmlElement(By by) : base(by) { }

        public HtmlElement(By by, IWebDriver driver) : base(by, driver) { }
    }
}
