using OpenQA.Selenium;

namespace SelenItEasy.Core.WebElements
{
    public class HtmlElement : EasyElement<HtmlElement>
    {
        public HtmlElement(IWebElement seleniumWebElement)
            : base(seleniumWebElement)
        {
        }

        public HtmlElement(By by)
            : base(by)
        {
        }

        public HtmlElement(By by, IWebDriver driver)
            : base(by, driver)
        {
        }
    }
}
