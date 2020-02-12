using FrameWork.PageObject;
using OpenQA.Selenium;

namespace FrameWork.Services
{
   public class PayServices
    {
        private IWebDriver webDriver;

        public PayServices(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public string PayWihoutFio() {
            var payPage = new PayPage(webDriver);
            payPage.ContinueButtonClick();
            string err = payPage.ErrorMessage.Text;
            return err;
        }
    }
}
