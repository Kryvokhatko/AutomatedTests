using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using prozorro.Model;

namespace prozorro.Test
{
    public class Tender_ownerTest : TestBase //inheritance from base class
    {
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Owner")]//comments
        public void Tender_ownerCanCreateAuctionTest()
        {
            OpenHomePage();
            ClickButtonLogin();
            Login(new AccountData("+380504444444", "123"));
            Assert.AreEqual("Альфа аукціон", driver.Title);
            clickButtonTradePlace();
            clickButtonCreateAuction();
            CreateAuction(new CreateAuctionData(
                //short name
                "Тестовый аукцион",
                //description of aplication
                "Описание заявки",
                //initial date of period
                "2016-09-05",
                //final date of period
                "2016-09-10",
                //initial date of period
                "2016-09-11",
                //final date of period
                "2016-09-15",
                //initial lot price
                "105",
                //minimal step of auction
                "1",
                //country
                "Украина",
                //region
                "Киевская",
                //city
                "Киев",
                //street
                "пр. Степана Бандеры, 9",
                //post code
                "010101",
                //contact person name
                "Вася Пупкин",
                //phone
                "+380504444444",
                //fax
                "+380442222222",
                //e-mail
                "testmail@alfabank.kiev.ua",
                //web site
                "http://www.alfabank.ua",
                //lot description
                "Тестовая продажа",
                //number of items
                "10",

                //lot location
                //country
                "Україна",
                //region
                "Дніпровська",
                //city
                "Дніпро",
                //street
                "ул. Улица, 11",
                //post code
                "020202"
                ));

            Assert.IsTrue(driver.FindElement(By.Id("Auction_Value_ValueAddedTaxIncluded")).Selected);
            Assert.IsTrue(driver.FindElement(By.Id("Auction_MinimalStep_ValueAddedTaxIncluded")).Selected);

            clickButtonSubmitAuction();
            Assert.AreEqual("Альфа аукціон", driver.Title);
            Assert.AreEqual(getAuctionIdFromWebPage(), getAuctionIdFromAzureDB());
            Assert.AreEqual(getAuctionTitleFromWebPage(), getAuctionTitleFromAzureDB());
            Assert.AreEqual(getAuctionDescriptionFromWebPage(), getAuctionDescriptionFromAzureDB());
        }
    }
}
