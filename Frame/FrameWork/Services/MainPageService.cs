using FrameWork.PageObject;
using OpenQA.Selenium;

namespace FrameWork.Services
{
    public class MainPageService
    {
        private IWebDriver webDriver;

        public MainPageService(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public bool SealesCheck() {
            var mainPage = new MainPage(webDriver);
            mainPage.ClickSaelseButton();
            return mainPage.Kreslo.Displayed;
        }
        public bool ConditionCheck()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.ClickConditionButton();
            return mainPage.ConditionTitle.Displayed;
        }
        public bool NewsCheck()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.ClickNewsButton();
            return mainPage.NewsTitle.Displayed;
        }
        public string incorrectNameCheck() {
            var mainPage = new MainPage(webDriver);
            mainPage.WaitForAMinute();
            mainPage.ClickOpenButton();
            mainPage.WaitForAMinute();
            mainPage.ClickHelloButton();
            mainPage.WaitForAMinute();
            mainPage.Refresh();
            mainPage.WaitForAMinute();
            mainPage.EnterName("adasd");
            mainPage.EnterNumber("1");
            mainPage.ClickEnterButton();
            return mainPage.InputNumber.GetCssValue("border-color").ToString();
        }
        public string incorrectPhoneCheck()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.WaitForAMinute();
            mainPage.ClickCallButton();
            mainPage.WaitForAMinute();
            mainPage.EntertelNumber("1");
            mainPage.ClickFinalCallButton();
            return mainPage.Callinput.GetCssValue("border-color").ToString();
        }
        public bool CatalogCheck()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.ClickCatalogButton();
            return mainPage.CatalogTitle.Displayed;
        }
        public bool ContactsCheck()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.ClicContactButton();
            return mainPage.ContactsTitle.Displayed;
        }
        public bool PriceCheck()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.ClicPriceButton();
            return mainPage.PriceTitle.Displayed;
        }
    }
}
