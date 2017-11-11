using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class TextBox : WebElement
    {
        private readonly IWebDriver _driver;
        private readonly By _by;

        public TextBox(IWebDriver driver, By by) : base(by)
        {
            _driver = driver;
            _by = by;
        }
    }
}
