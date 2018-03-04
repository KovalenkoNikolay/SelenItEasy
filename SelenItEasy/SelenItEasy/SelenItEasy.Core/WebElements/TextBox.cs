using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class TextBox : EasyElement<TextBox>
    {
        public TextBox(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public TextBox(By by) : base(by) { }

        public TextBox(By by, IWebDriver driver) : base(by, driver) { }
    }
}
