using OpenQA.Selenium;

namespace SelenItEasy.Core.WebElements
{
    public class DropDown : EasyElement<DropDown>
    {


        public DropDown(IWebElement seleniumWebElement) : base(seleniumWebElement) { }

		public DropDown(By by) : base(by) { }

        public DropDown(By by, IWebDriver driver) : base(by, driver) { }

        // TODO: Implement for DropDown
        //selectOption
        //selectOptionContainingText
        //selectOptionByValue
        //getSelectedOption
        //getSelectedOptions
        //getSelectedValue
        //getSelectedText
    }
}