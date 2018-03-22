using OpenQA.Selenium;

namespace SelenItEasy.Core.WebElements
{
    public class CheckBox : EasyElement<CheckBox>
    {
        public bool IsSelected => base._webElement.Selected;

        public CheckBox(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public CheckBox(By by) : base(by) { }

        public CheckBox(By by, IWebDriver driver) : base(by, driver) { }

        public CheckBox SetSelected(bool selected)
        {
            if (_webElement.Selected != selected)
                _webElement.Click();
            return this;
        }
    }
}