using OpenQA.Selenium;

namespace SelenItEasy.Core.WebElements
{
    public class Button : EasyElement<Button>
    {
        public Button(IWebElement seleniumWebElement) : base(seleniumWebElement) { }
        
        public Button(By by) : base(by) { }
        
        public Button(By by, IWebDriver driver) : base(by, driver) { }
    }
}
