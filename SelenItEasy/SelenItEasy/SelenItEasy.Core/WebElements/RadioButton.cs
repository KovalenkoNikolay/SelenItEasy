using OpenQA.Selenium;

namespace SelenItEasy.Core.WebElements
{
    public class RadioButton : EasyElement<RadioButton>
    {
        public RadioButton(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

        public RadioButton(By by) : base(by) { }

        public RadioButton(By by, IWebDriver driver) : base(by, driver) { }

        // TODO: Implement for RadioButton
        //selectRadio
    }
}
