using System.Drawing;
using OpenQA.Selenium;

namespace SelenItEasy.Core.WebElements
{
    public abstract class EasyElement<T>
    {
        public string TagName => this._webElement.TagName;

        public bool IsDisplayed => this._webElement.Displayed;

        public bool IsEnabled => this._webElement.Enabled;

        public Point Location => this._webElement.Location;

        public Size Size => this._webElement.Size;

        protected readonly IWebElement _webElement;

        public EasyElement(IWebElement seleniumWebElement)
        {
            _webElement = seleniumWebElement;
        }

        public EasyElement(By by)
        {
            _webElement = DriverManager.GetDriver().FindElement(by);
        }

        public EasyElement(By by, IWebDriver driver)
        {
            _webElement = driver.FindElement(by);
        }

        public T Click()
        {
            _webElement.Click();
            return (T)_webElement;
        }

        public string GetAttribute(string attributeName)
        {
            return _webElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            return _webElement.GetProperty(propertyName);
        }

        public string GetCssValue(string propertyName)
        {
            return _webElement.GetCssValue(propertyName);
        }

        public T ShouldBe()
        {
            return (T)_webElement;
        }


        // TODO: Implement for EasyElements
        // http://ru.selenide.org/javadoc.html
        // setValue
        // append
        //pressEnter

        //WebElement.sendKeys(Keys.TAB)
        //pressTab
        //pressEscape

        //getText
        // innerText
        //innerHtml
        //name
        //getValue
        //data
        //exists
        //isDisplayed

        //should
        //shouldHave
        //shouldBe
        //shouldNot
        //shouldNotHave
        //shouldNotBe
        //waitUntil(Condition condition,         long timeoutMilliseconds,                          long pollingIntervalMilliseconds)
        //waitWhile
        //toString
        //parent
        //closest
        //find
        //findAll

        //uploadFromClasspath
        //uploadFile

        //scrollTo
        //scrollIntoView
        //scrollIntoView
        //download
        //getSearchCriteria
        //toWebElement
        //getWrappedElement
        //doubleClick
        //contextClick
        //hover
        //dragAndDropTo
        //isImage

        //screenshot
        //screenshotAsImage
    }
}
