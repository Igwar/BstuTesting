using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace FrameWork.PageObject
{
    class PayPage
    {
        private IWebDriver webDriver;

        private static ILog logger = LogManager.GetLogger(typeof(Logger));
        public PayPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.ClassName, Using = Constants.ContinueButtonClass)]
        private IWebElement ContinueButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.InvalidLocationInputClass)]
        public IWebElement ErrorMessage { get; set; }
        private void WaitForAMinute()
        {
            logger.Info("Wait a minute");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }
        public void ContinueButtonClick() {
            logger.Info("Click continue button");
            ContinueButton.Click();
            WaitForAMinute();
        }

    }
}
