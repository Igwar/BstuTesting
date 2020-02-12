using FrameWork.WebDriver;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace FrameWork.Tests
{
    public class TestsConfig
    { 
        public IWebDriver webDriver;

        private static ILog logger = LogManager.GetLogger(typeof(Logger));

        [SetUp]
        public void InitWebDriver()
        {
            Logger.InitLogger();
            webDriver = WebDriverSetUp.GetInstance();
        }

        [TearDown]
        public void ClearDriver()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                var screen = webDriver.TakeScreenshot();
                screen.SaveAsFile("D:/EPAM/Epam-Testing/FrameWork/FrameWork/Screens" + "/screenshot" + DateTime.Now.ToString("yy-MM-dd_hh-mm-ss") + ".png",
                    ScreenshotImageFormat.Png);
                logger.Error("Test has failed");
            }
            logger.Info("Test has been complited successfully");
            WebDriverSetUp.CloseWebDriver();
        }
    }
}
