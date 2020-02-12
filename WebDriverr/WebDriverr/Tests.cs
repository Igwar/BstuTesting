using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebDriverr
{
   
        [TestFixture]
        class Tests
        {
            private IWebDriver driver;

            private IWebElement FindElementById(string id)
            {
                return driver.FindElement(By.Id(id));
            }

            private IWebElement FindElementByClass(string classname)
            {
                return driver.FindElement(By.ClassName(classname));
            }
            private IWebElement FindElementByXPath(string xpath)
            {
                return driver.FindElement(By.XPath(xpath));
            }

            private void WaitForAMinute()
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            }

            [TestCase]
            public void PayWithoutFIO()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://mir-avto.by/oplata-on-line/");

                var continueButton = FindElementByClass(Constants.ContinueButtonClass);
                continueButton.Click();
                WaitForAMinute();

                var errorMessage = FindElementByClass(Constants.InvalidLocationInputClass);
                Assert.AreEqual(Constants.InvalidLocationErrorMessage, errorMessage.Text);
                driver.Close();
            }


        [TestCase]
        public void OrderWithoutName()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mir-avto.by/prokat-avto/audi-a6-allroad/");
            var openButton = FindElementByClass(Constants.OpenButtonClass);
            openButton.Click();
            WaitForAMinute();
            var orderButton = FindElementById(Constants.OrderButtonId);
            orderButton.Click();
            WaitForAMinute();
            openButton = FindElementByClass(Constants.OpenButtonClass);
            openButton.Click();
            WaitForAMinute();
            var errorMessage = FindElementByXPath(Constants.ErrorXpath);
            Assert.AreEqual(Constants.ErrorMessage, errorMessage.Text);
            driver.Close();
        }
    }
    }

