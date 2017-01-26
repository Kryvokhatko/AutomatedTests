using System;

namespace prozorro.Model
{
    public class UserRegistrationData
    {
        //this class to keep client's registration data
        //fields for registration
        public string phone;
        public string firstName;
        public string lastName;
        public string middleName;
        public int companyID;
        public string respCompany;
        public string password;
        public string email;
        public string ipn;
        public string nationality;
        public string documentType;
        public string serial;
        public string number;
        public DateTime dateOpen;
        public string whoGive;
        public string cardNumber;
        public DateTime cardClose;
        public DateTime birthDay;
        public string resident;

        //constructor to pass an object with all fields
        public void userRegistrationData(
            string phone,
            string firstName,
            string lastName,
            string middleName,
            int companyID,
            string respCompany,
            string password,
            string email,
            string ipn,
            string nationality,
            string documentType,
            string serial,
            string number,
            DateTime dateOpen,
            string whoGive,
            string cardNumber,
            DateTime cardClose,
            DateTime birthDay,
            string resident)
        {
            this.phone = phone;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.companyID = companyID;
            this.respCompany = respCompany;
            this.password = password;
            this.email = email;
            this.ipn = ipn;
            this.nationality = nationality;
            this.documentType = documentType;
            this.serial = serial;
            this.number = number;
            this.dateOpen = dateOpen;
            this.whoGive = whoGive;
            this.cardNumber = cardNumber;
            this.cardClose = cardClose;
            this.birthDay = birthDay;
            this.resident = resident;
        }

        //properties for registration
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string CompanyID { get; set; }
        public string RespCompany { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string IPN { get; set; }
        public string Nationality { get; set; }
        public string DocumentType { get; set; }
        public string Serial { get; set; }
        public string Number { get; set; }
        public string DateOpen { get; set; }
        public string WhoGive { get; set; }
        public string CardNumber { get; set; }
        public string CardClose { get; set; }
        public string BirthDay { get; set; }
        public string Resident { get; set; }
    }
}
