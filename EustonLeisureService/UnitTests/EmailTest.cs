using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using Data;

namespace UnitTests
{
    [TestClass]
    public class EmailTest
    {

        [TestMethod]
        public void EmailHeaderPass()
        {
            Email email = new Email();
            email.Header = "E123456789";
        }

        [TestMethod]
        public void EmailHeaderInvalid()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Header = "S123456789");
        }

        [TestMethod]
        public void EmailHeaderTooLong()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Header = "E1234567891");
        }

        [TestMethod]
        public void EmailHeaderTooShort()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Header = "E12345678");
        }

        [TestMethod]
        public void EmailBodyPass()
        {
            Email email = new Email();
            email.Body = "test@gmail.com\r\nsubject\r\nbody";
        }

      

        [TestMethod]
        public void EmailSenderInvalid()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Body = "testgmail.com\r\nsubject\r\nbody");
        }

        [TestMethod]
        public void EmailSubjectTooLong()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Body = "test@gmail.com\r\nsubjecttttttttttttttt\r\nbody");
        }

        [TestMethod]
        public void MessageTextTooLong()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Body = "test@gmail.com\r\nsubject\r\nvulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet vulputate enim nulla aliquet porttitor lacus");
        }

        [TestMethod]
        public void SirBodyPass()
        {
            Email email = new Email();
            email.Body = "test@gmail.com\r\nSIR 20/20/20\r\n11-111-11\r\nRaid\r\nbody";
        }


        [TestMethod]
        public void SirSubjectInvalid()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Body = "test@gmail.com\r\nSIR 20/200/20\r\n11-111-11\r\nRaid\r\nbody");
        }

        [TestMethod]
        public void SirCodeInvalid()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Body = "test@gmail.com\r\nSIR 20/20/20\r\n11-111-111\r\nRaid\r\nbody");
        }

        [TestMethod]
        public void SirTypeInvalid()
        {
            Email email = new Email();
            Assert.ThrowsException<Exception>(() => email.Body = "test@gmail.com\r\nSIR 20/20/20\r\n11-111-111\r\nInjury\r\nbody");
        }



    }
}
