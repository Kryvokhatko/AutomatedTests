using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using prozorro.Model;
using System;

namespace prozorro.Test
{
    public class ViewerTest : TestBase //inheritance from base class
    {

        [Test]
        public void ViewerCanFindAuctionByIdTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var edrpo = driver.FindElement(By.Id("ProcuringEntity.Identifier.Id")).Text;
            Assert.AreEqual("5555555", edrpo);
        }

        [Test]
        public void ViewerCanSeeAuctionTitleTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var title = driver.FindElement(By.Id("Title")).Text;
            Assert.AreEqual("Тестовый аукцион", title);
        }

        [Test]
        public void ViewerCanSeeAuctionDescriptionTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var description = driver.FindElement(By.Id("Description")).Text;
            Assert.AreEqual("Описание заявки", description);
        }

        [Test]
        public void ViewerCanSeeAuctionCurrencyTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var currency = driver.FindElement(By.Id("Value.Currency")).Text;
            Assert.AreEqual("UAH", currency);
        }

        [Test]
        public void ViewerCanSeeAuctionVATTaxTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var vat = driver.FindElement(By.Id("Value.ValueAddedTaxIncluded")).FindElements(By.TagName("option"))[1].Text;
            Assert.AreEqual("True", vat);
        }

        [Test]
        public void ViewerCanSeeAuctionEndPeriodTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var end = driver.FindElement(By.Id("EnquiryPeriod_EndDate")).GetAttribute("value");
            Assert.AreEqual("2016.09.08 17:09:00", end);
        }

        [Test]
        public void ViewerCanSeeAuctionStartPeriodForPropositonTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var start = driver.FindElement(By.Id("TenderPeriod_StartDate")).GetAttribute("value");
            Assert.AreEqual("2016.09.08 17:09:00", start);
        }

        [Test]
        public void ViewerCanSeeAuctionEndPeriodForPropositonTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var end = driver.FindElement(By.Id("TenderPeriod_EndDate")).GetAttribute("value");
            Assert.AreEqual("2016.09.08 17:09:00", end);
        }

        [Test]
        public void ViewerCanSeeAuctionMinimalStepTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var min = driver.FindElement(By.Id("MinimalStep.Amount")).Text;
            Assert.AreEqual("1", min);
        }

        [Test]
        public void ViewerCanSeeAuctionSchemaTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var min = driver.FindElement(By.Id("item.Classification.scheme0")).Text;
            Assert.AreEqual("CAV", min);
        }

        [Test]
        public void ViewerCanSeeAuctionNomenclaturaDescriptionTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var description = driver.FindElement(By.Id("item.Classification.Description0")).Text;
            Assert.AreEqual("Нерухомість", description);
        }

        [Test]
        public void ViewerShowAuctionQuestionTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            driver.FindElement(By.Id("QuestionsCount")).Click();
            var time = driver.FindElement(By.Id("item.Date1")).Text;
            Assert.AreEqual("2016.09.09 10:44:58", time);
        }

        [Test]
        public void ViewerCanNotSeeBidsBeforeEndDateOfTenderPeriodTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr[1]/td[4]/a")).Click();
            var tmp = driver.FindElement(By.Id("AuctionTabs")).FindElements(By.XPath(".//*[@id='AuctionTabs']/li[3]/a")).ToString();
            Assert.AreNotEqual("Bid", tmp);
        }

        [Test]
        public void ViewerCanGetUrlForAuctionTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr[3]/td[4]/a")).Click();
            driver.FindElement(By.XPath(".//*[@id='AuctionInfoList']/a")).Click();
            driver.Navigate().GoToUrl("https://auction-sandbox.ea.openprocurement.org/auctions/ad3b0779ede14a24b26440900e05ff76");
            System.Threading.Thread.Sleep(3000);
        }

        [Test]
        public void ViewerCanSeeAuctionBudgetTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var time = driver.FindElement(By.Id("Value.Amount")).Text;
            Assert.AreEqual("105", time);
        }

        [Test]
        public void ViewerCanSeeAuctionIdTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var auctionId = driver.FindElement(By.Id("AuctionID")).Text;
            Assert.AreEqual("UA-EA-2016-09-09-000139", auctionId);
        }

        [Test]
        public void ViewerCanSeeEntityNameForSaleTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var entity = driver.FindElement(By.Id("ProcuringEntity.Name")).Text;
            Assert.AreEqual("Tender_owner", entity);
        }

        [Test]
        public void ViewerCanSeeQuestionHeaderWithoutAnswerTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            driver.FindElement(By.Id("QuestionsCount")).Click();
            var title = driver.FindElement(By.Id("item.Title1")).Text;
            Assert.AreEqual("asdfa", title);
        }

        [Test]
        public void ViewerCanSeeDescriptionOfQuestionWithoutAnswerTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            driver.FindElement(By.Id("QuestionsCount")).Click();
            driver.FindElement(By.Id("heading1")).Click();
            var description = driver.FindElement(By.Id("item.Description1")).Text;
            Assert.AreEqual("asdfasd", description);
        }

        [Test]
        public void ViewerCanSeeAnswerTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            driver.FindElement(By.Id("QuestionsCount")).Click();
            driver.FindElement(By.Id("heading1")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("item.Answer1")));
            var answer = driver.FindElement(By.Id("item.Answer1")).Text;
            Assert.AreEqual("дуже гарне запитання", answer);
        }

        [Test]
        public void ViewerCanSeeClassificatorIdTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var entity = driver.FindElement(By.Id("item.Classification.Id0")).Text;
            Assert.AreEqual("70123000-9", entity);
        }

        [Test]
        public void ViewerCanSeeDescriptionOfClassificatorTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var entity = driver.FindElement(By.Id("item.Classification.Description0")).Text;
            Assert.AreEqual("Нерухомість", entity);
        }

        [Test]
        public void ViewerCanSeeUnitNameInAuctionTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var entity = driver.FindElement(By.Id("item.Unit.Name0")).Text;
            Assert.AreEqual("гектар", entity);
        }

        [Test]
        public void ViewerCanSeeNumberOfUnitsInAuctionTest()
        {
            OpenHomePage();
            clickButtonTradePlace();
            Search(new SearchData("5555555"));
            driver.FindElement(By.XPath(".//*[@id='searchTable']/tbody/tr/td[4]/a")).Click();
            var entity = driver.FindElement(By.Id("item.Quantity0")).Text;
            Assert.AreEqual("10", entity);
        }
    }
}
