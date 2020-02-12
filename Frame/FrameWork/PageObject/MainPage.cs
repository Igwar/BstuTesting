using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace FrameWork.PageObject
{
   public class MainPage
    {
        private IWebDriver webDriver;

        private static ILog logger = LogManager.GetLogger(typeof(Logger));
        public MainPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.ClassName, Using = Constants.SealesButtionClass)]
        private IWebElement SealsButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.TitleClassName)]
        public IWebElement  Kreslo { get; set; }
        [FindsBy(How = How.Id, Using = Constants.ConditionsId)]
        private IWebElement ConditionsButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.TitleClassName)]
        public IWebElement ConditionTitle { get; set; }
        [FindsBy(How = How.Id, Using = Constants.NewsId)]
        private IWebElement NewsButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.TitleClassName)]
        public IWebElement NewsTitle { get; set; }
        public void WaitForAMinute()
        {
            logger.Info("Waiting for a 1 minute");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }
        public void ClickSaelseButton()
        {
            logger.Info("Click saelse button");
            SealsButton.Click();
            WaitForAMinute();
        }
        public void ClickConditionButton()
        {
            logger.Info("Click condition button");
            ConditionsButton.Click();
            WaitForAMinute();
        }
        public void ClickNewsButton()
        {
            logger.Info("Click news button");
            NewsButton.Click();
            WaitForAMinute();
        }
        [FindsBy(How = How.ClassName, Using = Constants.OpenButtonClass1)]
        private IWebElement OpenButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.InputNameClass)]
        private IWebElement InputName { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.InputNumberClass)]
        public IWebElement InputNumber { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.EnterButtonClass)]
        private IWebElement EnterButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.HelloButtonClass)]
        private IWebElement HelloButton { get; set; }
        public void ClickOpenButton()
        {
            logger.Info("Click open button");
            OpenButton.Click();
        
        }
        public void Refresh()
        {
            logger.Info("Refresh page");
            webDriver.Navigate().Refresh();
         
        }
        public void ClickHelloButton()
        {
            logger.Info("Click hello button");
            HelloButton.Click();
            
        }
        public void ClickEnterButton()
        {
            logger.Info("Click enter button");
            EnterButton.Click();
            
        }
        public void EnterName(string name)
        {
            logger.Info("Put name");
            if (InputName.Displayed)
                InputName.SendKeys(name);
           ;

        }
        public void EnterNumber(string name)
        {
            logger.Info("Put number");
            InputNumber.SendKeys(name);
            
        }
        [FindsBy(How = How.ClassName, Using = Constants.CallButtonClass)]
        private IWebElement CallButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.CallInputClass)]
        public IWebElement Callinput { get; set; }
        [FindsBy(How = How.Id, Using = Constants.CallFinalButtonId)]
        private IWebElement FinlaCallButton { get; set; }

        public void ClickCallButton()
        {
            logger.Info("Click call button");
            CallButton.Click();
           
        }
        public void ClickFinalCallButton()
        {
            logger.Info("Click end button");
            FinlaCallButton.Click();
           
        }
        public void EntertelNumber(string name)
        {
            logger.Info("Put number");
            Callinput.SendKeys(name);
            
        }
        [FindsBy(How = How.Id, Using = Constants.CatalogButtonId)]
        private IWebElement CatalogButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.TitleClassName)]
        public IWebElement CatalogTitle { get; set; }
        public void ClickCatalogButton()
        {
            logger.Info("Click catalog button");
            SealsButton.Click();
            WaitForAMinute();
        }
        [FindsBy(How = How.Id, Using = Constants.ContactsButtonId)]
        private IWebElement ContactsButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.TitleClassName)]
        public IWebElement ContactsTitle { get; set; }
        public void ClicContactButton()
        {
            logger.Info("Click contact button");
            ContactsButton.Click();
            WaitForAMinute();
        }
        [FindsBy(How = How.Id, Using = Constants.PriceButtonId)]
        private IWebElement PriceButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constants.TitleClassName)]
        public IWebElement PriceTitle { get; set; }
        public void ClicPriceButton()
        {
            logger.Info("Click price button");
            PriceButton.Click();
            WaitForAMinute();
        }
    }
}
