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
        private readonly IWebDriver _driver;
        private readonly By _by;

        public DropDown(IWebDriver driver, By by) : base(by)
        {
            _driver = driver;
            _by = by;
        }
    }
}
