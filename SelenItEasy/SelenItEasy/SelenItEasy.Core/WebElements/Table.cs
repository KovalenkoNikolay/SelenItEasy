using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class Table : EasyElement<Table>
    {
        public Table(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public Table(By by) : base(by) { }

        public Table(By by, IWebDriver driver) : base(by, driver) { }
    }
}
