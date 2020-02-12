using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace FrameWork.PageObject
{
    class OrderPage
    {
        private IWebDriver webDriver;

        private static ILog logger = LogManager.GetLogger(typeof(Logger));
        public OrderPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.ClassName, Using = Constants.OpenButtonClass)]
        private IWebElement OpenButton { get; set; }
        [FindsBy(How = How.Id, Using = Constants.OrderButtonId)]
        private IWebElement OrderButton { get; set; }
        [FindsBy(How = How.XPath, Using = Constants.ErrorXpath)]
        public IWebElement errorMessage { get; set; }
        private void WaitForAMinute()
        {
            logger.Info("Wait a minute");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }
        public void OpenButtonClick()
        {
            logger.Info("Open button click");
            OpenButton.Click();
            WaitForAMinute();
        }
        public void OrderButtonClick()
        {
            logger.Info("Open button click");
            OrderButton.Click();
            WaitForAMinute();
        }


    }
}
