using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prozorro.Model
{
    public class CreateAuctionData
    {
        //total information about auction
        //public string procurementMethodType;
        public string auctionTitle;
        public string auctionDescription;
        //refinements period
        public string auctionEnquiryPeriodStartDate;
        public string auctionEnquiryPeriodEndDate;
        //proposals period
        public string auctionTenderPeriodStartDate;
        public string auctionTenderPeriodEndDate;
        //initial lot price
        public string auctionValueAmount;
        //public string auctionValueCurrency;
        //public Boolean auctionValueValueAddedTaxIncluded;
        //minimal step for auction
        public string auctionMinimalStepAmount;
        //public string auctionMinimalStepCurrency;
        //public Boolean auctionMinimalStepValueAddedTaxIncluded;
        //company identification
        //public string auctionProcuringEntityName;
        //public string auctionProcuringEntityIdentifierScheme;
        //public string auctionProcuringEntityIdentifierId;
        //public string auctionProcuringEntityIdentifierLegalName;
        //address
        public string auctionProcuringEntityAddressCountryName;
        public string auctionProcuringEntityAddressRegion;
        public string auctionProcuringEntityAddressLocality;
        public string auctionProcuringEntityAddressStreetAddress;
        public string auctionProcuringEntityAddressPostalCode;
        //contact person
        public string auctionProcuringEntityContactPointName;
        public string auctionProcuringEntityContactPointTelephone;
        public string auctionProcuringEntityContactPointFaxNumber;
        public string auctionProcuringEntityContactPointEmail;
        public string auctionProcuringEntityContactPointUrl;
        //object for sale
        public string auctionItemsDescription;
        public string auctionItemsQuantity;
        //unit of measurement
        //public string unit;
        //public string auctionItemsUnitCode;
        //public string auctionItemsUnitName;
        //classification
        //public string auctionItemsClassification;
        //public string auctionItemsCavClassification;
        //public string auctionItemsClassificationId;
        //public string auctionItemsClassificationDescription;
        //lot location
        public string auctionItemsDeliveryAddressCountryName;
        public string auctionItemsDeliveryAddressRegion;
        public string auctionItemsDeliveryAddressLocality;
        public string auctionItemsDeliveryAddressStreetAddress;
        public string auctionItemsDeliveryAddressPostalCode;

        public CreateAuctionData
            (
                //total information about auction
                //string procurementMethodType,
                string auctionTitle,
                string auctionDescription,
                //refinements period
                string auctionEnquiryPeriodStartDate,
                string auctionEnquiryPeriodEndDate,
                //proposals period
                string auctionTenderPeriodStartDate,
                string auctionTenderPeriodEndDate,
                //initial lot price
                string auctionValueAmount,
                //string auctionValueCurrency,
                //Boolean auctionValueValueAddedTaxIncluded,
                //minimal step for auction
                string auctionMinimalStepAmount,
                //string auctionMinimalStepCurrency,
                //Boolean auctionMinimalStepValueAddedTaxIncluded,
                //company identification
                //string auctionProcuringEntityName,
                //string auctionProcuringEntityIdentifierScheme,
                //string auctionProcuringEntityIdentifierId,
                //string auctionProcuringEntityIdentifierLegalName,
                //address
                string auctionProcuringEntityAddressCountryName,
                string auctionProcuringEntityAddressRegion,
                string auctionProcuringEntityAddressLocality,
                string auctionProcuringEntityAddressStreetAddress,
                string auctionProcuringEntityAddressPostalCode,
                //contact person
                string auctionProcuringEntityContactPointName,
                string auctionProcuringEntityContactPointTelephone,
                string auctionProcuringEntityContactPointFaxNumber,
                string auctionProcuringEntityContactPointEmail,
                string auctionProcuringEntityContactPointUrl,
                //object for sale
                string auctionItemsDescription,
                string auctionItemsQuantity,
                //unit of measurement
                //string unit,
                //string auctionItemsUnitCode,
                //string auctionItemsUnitName,
                //classification
                //string auctionItemsClassification,
                //string auctionItemsCavClassification,
                //string auctionItemsClassificationId,
                //string auctionItemsClassificationDescription,
                //lot location
                string auctionItemsDeliveryAddressCountryName,
                string auctionItemsDeliveryAddressRegion,
                string auctionItemsDeliveryAddressLocality,
                string auctionItemsDeliveryAddressStreetAddress,
                string auctionItemsDeliveryAddressPostalCode
            )
        {
            //this.procurementMethodType = procurementMethodType;
            this.auctionTitle = auctionTitle;
            this.auctionDescription = auctionDescription;
            //refinements period
            this.auctionEnquiryPeriodStartDate = auctionEnquiryPeriodStartDate;
            this.auctionEnquiryPeriodEndDate = auctionEnquiryPeriodEndDate;
            //proposals period
            this.auctionTenderPeriodStartDate = auctionTenderPeriodStartDate;
            this.auctionTenderPeriodEndDate = auctionTenderPeriodEndDate;
            //initial lot price
            this.auctionValueAmount = auctionValueAmount;
            //this.auctionValueCurrency = auctionValueCurrency;
            //this.auctionValueValueAddedTaxIncluded = auctionValueValueAddedTaxIncluded;
            //minimal step for auction
            this.auctionMinimalStepAmount = auctionMinimalStepAmount;
            //this.auctionMinimalStepCurrency = auctionMinimalStepCurrency;
            //this.auctionMinimalStepValueAddedTaxIncluded = auctionMinimalStepValueAddedTaxIncluded;
            //company identification
            //this.auctionProcuringEntityName = auctionProcuringEntityName;
            //this.auctionProcuringEntityIdentifierScheme = auctionProcuringEntityIdentifierScheme;
            //this.auctionProcuringEntityIdentifierId = auctionProcuringEntityIdentifierId;
            //this.auctionProcuringEntityIdentifierLegalName = auctionProcuringEntityIdentifierLegalName;
            //address
            this.auctionProcuringEntityAddressCountryName = auctionProcuringEntityAddressCountryName;
            this.auctionProcuringEntityAddressRegion = auctionProcuringEntityAddressRegion;
            this.auctionProcuringEntityAddressLocality = auctionProcuringEntityAddressLocality;
            this.auctionProcuringEntityAddressStreetAddress = auctionProcuringEntityAddressStreetAddress;
            this.auctionProcuringEntityAddressPostalCode = auctionProcuringEntityAddressPostalCode;
            //contact person
            this.auctionProcuringEntityContactPointName = auctionProcuringEntityContactPointName;
            this.auctionProcuringEntityContactPointTelephone = auctionProcuringEntityContactPointTelephone;
            this.auctionProcuringEntityContactPointFaxNumber = auctionProcuringEntityContactPointFaxNumber;
            this.auctionProcuringEntityContactPointEmail = auctionProcuringEntityContactPointEmail;
            this.auctionProcuringEntityContactPointUrl = auctionProcuringEntityContactPointUrl;
            //object for sale
            this.auctionItemsDescription = auctionItemsDescription;
            this.auctionItemsQuantity = auctionItemsQuantity;
            //unit of measurement
            //this.unit = unit;
            //this.auctionItemsUnitCode = auctionItemsUnitCode;
            //this.auctionItemsUnitName = auctionItemsUnitName;
            //classification
            //this.auctionItemsClassification = auctionItemsClassification;
            //this.auctionItemsCavClassification = auctionItemsCavClassification;
            //this.auctionItemsClassificationId = auctionItemsClassificationId;
            //this.auctionItemsClassificationDescription = auctionItemsClassificationDescription;
            //lot location
            this.auctionItemsDeliveryAddressCountryName = auctionItemsDeliveryAddressCountryName;
            this.auctionItemsDeliveryAddressRegion = auctionItemsDeliveryAddressRegion;
            this.auctionItemsDeliveryAddressLocality = auctionItemsDeliveryAddressLocality;
            this.auctionItemsDeliveryAddressStreetAddress = auctionItemsDeliveryAddressStreetAddress;
            this.auctionItemsDeliveryAddressPostalCode = auctionItemsDeliveryAddressPostalCode;
        }
        //total information about auction
        //public string ProcurementMethodType { get; set; }
        public string AuctionTitle { get; set; }
        public string AuctionDescription { get; set; }
        //refinements period
        public string AuctionEnquiryPeriodStartDate { get; set; }
        public string AuctionEnquiryPeriodEndDate { get; set; }
        //proposals period
        public string AuctionTenderPeriodStartDate { get; set; }
        public string AuctionTenderPeriodEndDate { get; set; }
        //initial lot price
        public string AuctionValueAmount { get; set; }
        //public string AuctionValueCurrency { get; set; }
        //public Boolean AuctionValueValueAddedTaxIncluded { get; set; }
        //minimal step for auction
        public string AuctionMinimalStepAmount { get; set; }
        //public string AuctionMinimalStepCurrency { get; set; }
        //public Boolean AuctionMinimalStepValueAddedTaxIncluded { get; set; }
        //company identification
        //public string AuctionProcuringEntityName { get; set; }
        //public string AuctionProcuringEntityIdentifierScheme { get; set; }
        //public string AuctionProcuringEntityIdentifierId { get; set; }
        //public string AuctionProcuringEntityIdentifierLegalName { get; set; }
        //address
        public string AuctionProcuringEntityAddressCountryName { get; set; }
        public string AuctionProcuringEntityAddressRegion { get; set; }
        public string AuctionProcuringEntityAddressLocality { get; set; }
        public string AuctionProcuringEntityAddressStreetAddress { get; set; }
        public string AuctionProcuringEntityAddressPostalCode { get; set; }
        //contact person
        public string AuctionProcuringEntityContactPointName { get; set; }
        public string AuctionProcuringEntityContactPointTelephone { get; set; }
        public string AuctionProcuringEntityContactPointFaxNumber { get; set; }
        public string AuctionProcuringEntityContactPointEmail { get; set; }
        public string AuctionProcuringEntityContactPointUrl { get; set; }
        //object for sale
        public string AuctionItemsDescription { get; set; }
        public string AuctionItemsQuantity { get; set; }
        //unit of measurement
        //public string Unit { get; set; }
        //public string AuctionItemsUnitCode { get; set; }
        //public string AuctionItemsUnitName { get; set; }
        //classification
        //public string AuctionItemsClassification { get; set; }
        //public string AuctionItemsCavClassification { get; set; }
        //public string AuctionItemsClassificationId { get; set; }
        //public string AuctionItemsClassificationDescription { get; set; }
        //lot location
        public string AuctionItemsDeliveryAddressCountryName { get; set; }
        public string AuctionItemsDeliveryAddressRegion { get; set; }
        public string AuctionItemsDeliveryAddressLocality { get; set; }
        public string AuctionItemsDeliveryAddressStreetAddress { get; set; }
        public string AuctionItemsDeliveryAddressPostalCode { get; set; }
    }
}
