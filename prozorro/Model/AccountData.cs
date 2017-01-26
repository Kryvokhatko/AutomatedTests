using System;

namespace prozorro.Model
{
    //for authorisation purpouse we shell pass an instance of AccountData class to the test class
    public class AccountData
    {
        //fields for authorisation
        public string phone;
        public string sms;

        //constructor  
        public AccountData(string phone, string sms)
        {
            this.phone = phone;
            this.sms = sms;
        }

        //properties for authorisation
        public string Phone { get; set; }
        public string Sms { get; set; }
    }
}
