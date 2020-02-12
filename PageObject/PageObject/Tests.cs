using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void Test()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://mir-avto.by/");

            SendPage page1 = new SendPage(webDriver)
                .Wait(6000)
                
              .ClickOpenButton()
              .Wait(6000)
              .ClickHelloButton()
                .Wait(6000)
              .Refresh()
            
             
              
              .Wait(6000)
              .EnterName("adasd")
              .EnterNumber("1")
              .ClickEnterButton();

            Assert.AreEqual("rgb(0, 0, 0) rgb(0, 0, 0) rgb(204, 204, 204)", page1.InputNumber.GetCssValue("border-color").ToString());
            
            webDriver.Close();
        }
        [TestCase]
        public void Test2() 
        {

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://mir-avto.by/");
            CallPage page1 = new CallPage(webDriver)
                  .Wait(6000)
                  .ClickCallButton()
                  .Wait(6000)
                  .EnterNumber("1")
                  .ClickFinalCallButton();
                   Assert.AreEqual("rgb(204, 204, 204)", page1.Callinput.GetCssValue("border-color").ToString());

        }
    }
}
