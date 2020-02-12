using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObject.Pages
{
    class CallPage
    { 

        private IWebDriver webDriver;
        public CallPage(IWebDriver webDriver)
    {
        this.webDriver = webDriver;
        PageFactory.InitElements(webDriver, this);
    }
        [FindsBy(How = How.ClassName, Using = Constant.CallButtonClass)]
        private IWebElement CallButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constant.CallInputClass)]
        public IWebElement Callinput { get; set; }
        [FindsBy(How = How.Id, Using = Constant.CallFinalButtonId)]
        private IWebElement FinlaCallButton { get; set; }

        public CallPage ClickCallButton()
        {
            CallButton.Click();
            return this;
        }
        public CallPage ClickFinalCallButton()
        {
            FinlaCallButton.Click();
            return this;
        }
        public CallPage EnterNumber(string name)
        {
           Callinput.SendKeys(name);
            return this;
        }
        public CallPage Wait(int i)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
           // Thread.Sleep(i);
            return this;
        }

    }
}
