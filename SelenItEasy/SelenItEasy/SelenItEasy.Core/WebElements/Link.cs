using OpenQA.Selenium;

namespace SelenItEasy.Core.WebElements
{
    public class Link : EasyElement<Link>
    {
        public string Href => base._webElement.GetAttribute("href");

        public Link(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public Link(By by) : base(by) { }

        public Link(By by, IWebDriver driver) : base(by, driver) { }
    }
}
