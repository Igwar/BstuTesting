using FrameWork.PageObject;
using OpenQA.Selenium;


namespace FrameWork.Services
{
    public class OrderService
    {
        private IWebDriver webDriver;

        public OrderService(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public string OrderWithoutName()
        {
            var orderPage = new OrderPage(webDriver);
            orderPage.OpenButtonClick();
            orderPage.OrderButtonClick();
            orderPage.OpenButtonClick();
            string err = orderPage.errorMessage.Text;
            return err;
        }
    }
}
