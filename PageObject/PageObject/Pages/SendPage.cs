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
    class SendPage
    {
        private IWebDriver webDriver;
        public SendPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = Constant.OpenButtonClass)]
        private IWebElement OpenButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constant.InputNameClass)]
        private IWebElement InputName{ get; set; }
        [FindsBy(How = How.ClassName, Using = Constant.InputNumberClass)]
        public IWebElement InputNumber{ get; set; }
        [FindsBy(How = How.ClassName, Using = Constant.EnterButtonClass)]
        private IWebElement EnterButton { get; set; }
        [FindsBy(How = How.ClassName, Using = Constant.HelloButtonClass)]
        private IWebElement HelloButton { get; set; }
        public SendPage ClickOpenButton()
        {
            OpenButton.Click();
            return this;
        }
        public SendPage Refresh()
        {
            webDriver.Navigate().Refresh();
            return this;
        }
        public SendPage ClickHelloButton()
        {
            HelloButton.Click();
            return this;
        }
        public SendPage ClickEnterButton()
        {
            EnterButton.Click();
            return this;
        }
        public SendPage EnterName(string name)
        {
            if(InputName.Displayed)
                InputName.SendKeys(name);
                return this;
            
        }
        public SendPage EnterNumber(string name)
        {
            InputNumber.SendKeys(name);
            return this;
        }
        public SendPage Wait(int i)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
           // Thread.Sleep(i);
            return this;
        }
    }
}
