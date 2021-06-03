using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using Data;

namespace UnitTests
{
    [TestClass]
    public class SMSTest
    {
        [TestMethod]
        public void SMSHeaderPass()
        {
            SMS sms = new SMS();
            sms.Header = "S123456789";
        }

        [TestMethod]
        public void SMSHeaderInvalid()
        {
            SMS sms = new SMS();
            Assert.ThrowsException<Exception>(() => sms.Header = "E123456789");
        }

        [TestMethod]
        public void SMSHeaderTooLong()
        {
            SMS sms = new SMS();
            Assert.ThrowsException<Exception>(() => sms.Header = "E1234567891");
        }

        [TestMethod]
        public void SMSHeaderTooShort()
        {
            SMS sms = new SMS();
            Assert.ThrowsException<Exception>(() => sms.Header = "E12345678");
        }

        [TestMethod]
        public void SMSBodyPass()
        {
            SMS sms = new SMS();
            sms.Body = "+44 2727 2727\r\nhello";
        }

       

        [TestMethod]
        public void SMSInvalidPhoneNo()
        {
            SMS sms = new SMS();
            Assert.ThrowsException<Exception>(() => sms.Body = "+54 4444 4444 22 22 222\r\nhello");
        }

        [TestMethod]
        public void MessageTooLong()
        {
            SMS sms = new SMS();
            Assert.ThrowsException<Exception>(() => sms.Body = "+434 2727 2722\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum rutrum sodales. Nullam mattis fermentum libero, non volutpat..");
        }
       
        [TestMethod]
        public void 
        {
            SMS sms = new SMS();
            sms.Body = "+43 2727 2722\r\nLOL";
            Assert.AreEqual(sms.Body, "+43 2727 2722 LOL <Laughing out loud>");
        }


    }
}
