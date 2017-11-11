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
        private readonly IWebDriver _driver;
        private readonly By _by;

        public Link(By by) : base(by)
        {
            _driver = DriverManager.GetDriver();
            _by = by;
        }

        public Link(By by, IWebDriver driver) : base(by, driver)
        {
            _driver = driver;
            _by = by;
        }
    }
}
