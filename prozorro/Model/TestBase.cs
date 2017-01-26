using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;
using System.Text;
using OpenQA.Selenium.Support.UI;
using Microsoft.Azure.Documents.Client;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace prozorro.Model
{
    //all methods for all tests
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        [SetUp]
        public void SetUpTest()
        {
            ChromeOptions options = new ChromeOptions();
            //discard all extensions (to eleminate confirmation queries from browser)
            options.AddArgument("disable-extensions");
            //pass variable options to the new ChromeDriver instant to run browser with parameters
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            baseURL = "http://zorro-test.azurewebsites.net";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        //stop driver after test
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //Ignore errors if unable to close the browser
            }

            Assert.AreEqual("", verificationErrors.ToString());
        }

        //site authorisation method
        protected void Login(AccountData account)
        {
            driver.FindElement(By.CssSelector("#Phone")).Clear();
            driver.FindElement(By.CssSelector("#Phone")).SendKeys(account.phone);
            driver.FindElement(By.CssSelector(".btn.btn-default")).Click();
            driver.FindElement(By.CssSelector("#Code")).Clear();
            driver.FindElement(By.CssSelector("#Code")).SendKeys(account.sms);
            driver.FindElement(By.CssSelector(".btn.btn-default")).Click();
        }

        protected void Logout()
        {
            driver.FindElement(By.CssSelector(".nav.navbar-nav.navbar-right>li>a")).Click();
        }

        protected void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
        }

        protected void ClickButtonLogin()
        {
            driver.FindElement(By.CssSelector("#loginLink")).Click();
        }

        protected void FillRegistrationForm(UserRegistrationData regdata)
        {
            throw new NotImplementedException();
        }

        protected void Search(SearchData field)
        {
            driver.FindElement(By.CssSelector(".nav.navbar-nav>li>a")).Click();
            driver.FindElement(By.CssSelector("#search-term")).Clear();
            driver.FindElement(By.CssSelector("#search-term")).SendKeys(field.search);
            driver.FindElement(By.Id("accurate")).Click();
            driver.FindElement(By.XPath("html/body/div[3]/div[2]/form/input[2]")).Click();
        }

        protected void clickButtonTradePlace()
        {
            driver.FindElement(By.LinkText("Торгівельний майданчик")).Click();
        }

        protected void clickButtonCreateAuction()
        {
            driver.FindElement(By.LinkText("Створити заявку")).Click();
        }

        protected void clickButtonSubmitAuction()
        {
            driver.FindElement(By.Id("createOrder")).Click();
        }

        protected void CreateAuction(CreateAuctionData auction)
        {
            //total information about auction
            var list = driver.FindElement(By.Id("Auction_ProcurementMethodType"));
            var dropdownProcedure = new SelectElement(list);
            dropdownProcedure.SelectByText("Потрібна фін ліцензія");
            //dropdownProcedure.SelectByText("Не потрібна фін ліцензія");
            driver.FindElement(By.Id("Auction_Title")).Clear();
            driver.FindElement(By.Id("Auction_Title")).SendKeys(auction.auctionTitle);
            driver.FindElement(By.Id("Auction_Description")).Clear();
            driver.FindElement(By.Id("Auction_Description")).SendKeys(auction.auctionDescription);
            //refinemet period
            driver.FindElement(By.Id("Auction_EnquiryPeriod_StartDate")).Click();
            driver.FindElement(By.Id("Auction_EnquiryPeriod_StartDate")).SendKeys(auction.auctionEnquiryPeriodStartDate);
            driver.FindElement(By.Id("Auction_EnquiryPeriod_EndDate")).Click();
            driver.FindElement(By.Id("Auction_EnquiryPeriod_EndDate")).SendKeys(auction.auctionEnquiryPeriodEndDate);
            //proposals period
            driver.FindElement(By.Id("Auction_TenderPeriod_StartDate")).Click();
            driver.FindElement(By.Id("Auction_TenderPeriod_StartDate")).SendKeys(auction.auctionTenderPeriodStartDate);
            driver.FindElement(By.Id("Auction_TenderPeriod_EndDate")).Click();
            driver.FindElement(By.Id("Auction_TenderPeriod_EndDate")).SendKeys(auction.auctionTenderPeriodEndDate);
            //initial lot price
            driver.FindElement(By.Id("Auction_Value_Amount")).Clear();
            driver.FindElement(By.Id("Auction_Value_Amount")).SendKeys(auction.auctionValueAmount);
            var currency1 = driver.FindElement(By.Id("Auction_Value_Currency"));
            var dropdownCurrency1 = new SelectElement(currency1);
            dropdownCurrency1.SelectByText("Гривня");
            //dropdownProcedure.SelectByText("Американський доллар");
            driver.FindElement(By.Id("Auction_Value_ValueAddedTaxIncluded")).Click();
            //minimal step for auction
            driver.FindElement(By.Id("Auction_MinimalStep_Amount")).Clear();
            driver.FindElement(By.Id("Auction_MinimalStep_Amount")).SendKeys(auction.auctionMinimalStepAmount);
            var currency2 = driver.FindElement(By.Id("Auction_Value_Currency"));
            var dropdownCurrency2 = new SelectElement(currency2);
            dropdownCurrency2.SelectByText("Гривня");
            driver.FindElement(By.Id("Auction_MinimalStep_ValueAddedTaxIncluded")).Click();
            //company information
            //company identification
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Name")).Clear();
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Name")).SendKeys("Тестовый АльфаБанк");
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Identifier_Scheme")).Clear();
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Identifier_Scheme")).SendKeys("UA-EDR");
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Identifier_Id")).Clear();
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Identifier_Id")).SendKeys("123456");
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Identifier_LegalName")).Clear();
            //driver.FindElement(By.Id("Auction_ProcuringEntity_Identifier_LegalName")).SendKeys("АО Тестовый АльфаБанк");
            //address
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_CountryName")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_CountryName")).SendKeys(auction.auctionProcuringEntityAddressCountryName);
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_Region")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_Region")).SendKeys(auction.auctionProcuringEntityAddressRegion);
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_Locality")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_Locality")).SendKeys(auction.auctionProcuringEntityAddressLocality);
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_StreetAddress")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_StreetAddress")).SendKeys(auction.auctionProcuringEntityAddressStreetAddress);
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_PostalCode")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_Address_PostalCode")).SendKeys(auction.auctionProcuringEntityAddressPostalCode);
            //contact person
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Name")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Name")).SendKeys(auction.auctionProcuringEntityContactPointName);
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Telephone")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Telephone")).SendKeys(auction.auctionProcuringEntityContactPointTelephone);
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_FaxNumber")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_FaxNumber")).SendKeys(auction.auctionProcuringEntityContactPointFaxNumber);
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Email")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Email")).SendKeys(auction.auctionProcuringEntityContactPointEmail);
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Url")).Clear();
            driver.FindElement(By.Id("Auction_ProcuringEntity_ContactPoint_Url")).SendKeys(auction.auctionProcuringEntityContactPointUrl);
            //object for sale
            driver.FindElement(By.Id("Auction_Items_0__Description")).Clear();
            driver.FindElement(By.Id("Auction_Items_0__Description")).SendKeys(auction.auctionItemsDescription);
            driver.FindElement(By.Id("Auction_Items_0__Quantity")).Clear();
            driver.FindElement(By.Id("Auction_Items_0__Quantity")).SendKeys(auction.auctionItemsQuantity);
            //unit of measurement
            var units = driver.FindElement(By.Id("Auction_Items_0__Unit_unit"));
            var dropdownUnits = new SelectElement(units);
            dropdownUnits.SelectByText("гектар");
            //classification
            //driver.FindElement(By.Id("Auction_Items_0__Classification_scheme")).Clear();
            //driver.FindElement(By.Id("Auction_Items_0__Classification_scheme")).SendKeys("CAV");
            driver.FindElement(By.Id("Auction_Items_0__Classification_CavClassification")).Clear();
            var ee = driver.FindElement(By.Id("Auction_Items_0__Classification_CavClassification"));
            ee.SendKeys("Нерухомість");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ui-id-2")));
            ee.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ee.SendKeys(OpenQA.Selenium.Keys.Enter);
            //driver.FindElement(By.Id("Auction_Items_0__Classification_Id")).Clear();
            //driver.FindElement(By.Id("Auction_Items_0__Classification_Id")).SendKeys(auction.auctionItemsClassificationId);
            //driver.FindElement(By.Id("Auction_Items_0__Classification_Description")).Clear();
            //driver.FindElement(By.Id("Auction_Items_0__Classification_Description")).SendKeys(auction.auctionItemsClassificationDescription);
            //lot location
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_CountryName")).Clear();
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_CountryName")).SendKeys(auction.auctionItemsDeliveryAddressCountryName);
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_Region")).Clear();
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_Region")).SendKeys(auction.auctionItemsDeliveryAddressRegion);
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_Locality")).Clear();
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_Locality")).SendKeys(auction.auctionItemsDeliveryAddressLocality);
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_StreetAddress")).Clear();
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_StreetAddress")).SendKeys(auction.auctionItemsDeliveryAddressStreetAddress);
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_PostalCode")).Clear();
            driver.FindElement(By.Id("Auction_Items_0__DeliveryAddress_PostalCode")).SendKeys(auction.auctionItemsDeliveryAddressPostalCode);
        }

        public string getAuctionIdFromWebPage()
        {
            //id from prozoro DB (external)
            return (string)driver.FindElement(By.Id("Id")).Text;
        }

        public string getAuctionTitleFromWebPage()
        {
            return (string)driver.FindElement(By.Id("Title")).Text;
        }

        public string getAuctionDescriptionFromWebPage()
        {
            return (string)driver.FindElement(By.Id("Description")).Text;
        }

        public string getAuctionIdFromAzureDB()
        {
            string databaseName = "***";
            string collectionName = "***";
            var DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);
            var idFromWebPage = driver.FindElement(By.Id("Id")).Text;
            var doc = DocumentDBClient.DocumentClient().CreateDocumentQuery<object>(DocumentCollectionUri, String.Format(@"select * from c where c.auction.id = ""{0}""", idFromWebPage))
                .ToList()
                .FirstOrDefault();
            var json = JObject.Parse(doc.ToString());
            return json.SelectToken("auction.id").Value<string>();
        }

        public string getAuctionTitleFromAzureDB()
        {
            string databaseName = "***";
            string collectionName = "***";
            var DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);
            var idFromWebPage = driver.FindElement(By.Id("Id")).Text;
            var auctionTitleFromAzureDB = DocumentDBClient.DocumentClient().CreateDocumentQuery<object>(DocumentCollectionUri, String.Format(@"select * from c where c.auction.id = ""{0}""", idFromWebPage))
                .ToList()
                .FirstOrDefault();
            var json = JObject.Parse(auctionTitleFromAzureDB.ToString());
            return json.SelectToken("auction.title").Value<string>();
        }

        public string getAuctionDescriptionFromAzureDB()
        {
            string databaseName = "***";
            string collectionName = "***";
            var DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);
            var idFromWebPage = driver.FindElement(By.Id("Id")).Text;
            var auctionDescriptionFromAzureDB = DocumentDBClient.DocumentClient().CreateDocumentQuery<object>(DocumentCollectionUri, String.Format(@"select * from c where c.auction.id = ""{0}""", idFromWebPage))
                .ToList()
                .FirstOrDefault();
            var json = JObject.Parse(auctionDescriptionFromAzureDB.ToString());
            return json.SelectToken("auction.description").Value<string>();
        }

        public void clickButtonBid()
        {
            driver.FindElement(By.XPath(".//*[@id='AuctionTabs']/li[3]/a")).Click();
        }

        public void clickButtonSetBid()
        {
            driver.FindElement(By.Id("b_setBid")).Click();
        }
    }
}
