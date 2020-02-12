using FrameWork;
using FrameWork.Services;
using FrameWork.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation
{
    class TestsCI : TestsConfig
    {
       
        private PayServices payServices;
        private OrderService orderService;
        private MainPageService mainPageService;
        private const string payPageUrl = "https://mir-avto.by/oplata-on-line/";
        private const string orederPageUrl = "https://mir-avto.by/prokat-avto/audi-a6-allroad/";
        private const string mainPageUrl = "https://mir-avto.by/";
        private void GoToPage(string pageUrl)
        {
            webDriver.Navigate().GoToUrl(pageUrl);
        }

        [Test]
        public void PayWithoutFIO_ExpectAreEqual()
        {
            //Arrange
            GoToPage(payPageUrl);
            payServices = new PayServices(webDriver);

            //Act
            var error = payServices.PayWihoutFio();

            //Assert
            Assert.AreEqual(Constants.InvalidLocationErrorMessage, error);
              
    }

        [Test]
        public void OrderWithotFio_ExpectAreEqual()
        {
            //Arrange
            GoToPage(orederPageUrl);
            orderService = new OrderService(webDriver);

            //Act 
            var error= orderService.OrderWithoutName();

            //Assert
            Assert.AreEqual(Constants.ErrorMessage, error);
        }

        [Test]
        public void SealceCheck_ExpectIsTrue()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);

            //Act
            var sealseIsOpend = mainPageService.SealesCheck();

            //Assert
            Assert.IsTrue(sealseIsOpend);
        }

        [Test]
        public void ConditionsChec_ExpectIsTrue()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);

            //Act
            var conditionIsOpen = mainPageService.ConditionCheck();

            //Assert
            Assert.IsTrue(conditionIsOpen);
        }

        [Test]
        public void NewsCheck_ExpectIsTrue()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);

            //Act
            var newsIsOpen = mainPageService.NewsCheck();

            //Assert
            Assert.IsTrue(newsIsOpen);
        }

        [Test]
        public void EnterInvalidName_ExpectAreEqual()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);


            //Act
            var color = mainPageService.incorrectNameCheck();

            //Assert
            Assert.AreEqual("rgb(0, 0, 0) rgb(0, 0, 0) rgb(204, 204, 204)", color);
        }

        [Test]
        public void EnterInvalidPhone_ExpectAreEqual()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);

            //Act
            var color = mainPageService.incorrectPhoneCheck();

            //Assert
            Assert.AreEqual("rgb(204, 204, 204)",color);
        }

        [Test]
        public void CatalogCheck_ExpectIsTrue()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);

            //Act
            var catalogIsOpen = mainPageService.CatalogCheck();

            //Assert
            Assert.IsTrue(catalogIsOpen);
        }

        [Test]
        public void ContactsCheck_ExpectIsTrue()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);

            //Act
            var contactsIsOpen = mainPageService.ContactsCheck();

            //Assert
            Assert.IsTrue(contactsIsOpen);
        }

        [Test]
        public void PriceCheck_ExpectIsTrue()
        {
            //Arrange
            GoToPage(mainPageUrl);
            mainPageService = new MainPageService(webDriver);

            //Act
            var priceIsOpen = mainPageService.PriceCheck();

            //Assert
            Assert.IsTrue(priceIsOpen);
        }
    }
}
