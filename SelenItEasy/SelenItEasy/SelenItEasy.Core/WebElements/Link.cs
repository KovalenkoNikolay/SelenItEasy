using System;
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
        public string Href => base._webElement.GetAttribute("href");

        public Link(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public Link(By by) : base(by) { }

        public Link(By by, IWebDriver driver) : base(by, driver) { }
    }
}
