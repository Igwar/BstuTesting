using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FrameWork.WebDriver
{
    public class WebDriverSetUp
    {
        private static IWebDriver webDriver;

        private WebDriverSetUp() { }

        public static IWebDriver GetInstance()
        {
            switch (TestContext.Parameters.Get("browser"))
            {
                case "Edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    webDriver = new EdgeDriver();
                    break;
                default:
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    webDriver = new ChromeDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return webDriver;
        }

        public static void CloseWebDriver()
        {
            webDriver.Quit();
            webDriver = null;
        }
    }
}
