using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using Data;

namespace UnitTests
{
    [TestClass]
    public class TweetTest
    {

        private DataManager dataManager = new DataManager();

        [TestMethod]
        public void TweetHeaderPass()
        {
            Tweet tweet = new Tweet();
            tweet.Header = "T123456789";
        }

        [TestMethod]
        public void TweetHeaderInvalid()
        {
            Tweet tweet = new Tweet();
            Assert.ThrowsException<Exception>(() => tweet.Header = "E123456789");
        }

        [TestMethod]
        public void TweetHeaderTooLong()
        {
            Tweet tweet = new Tweet();
            Assert.ThrowsException<Exception>(() => tweet.Header = "T1234567891");
        }

        [TestMethod]
        public void TweetHeaderTooShort()
        {
            Tweet tweet = new Tweet();
            Assert.ThrowsException<Exception>(() => tweet.Header = "T12345678");
        }

        [TestMethod]
        public void TweetBodyPass()
        {
            Tweet tweet = new Tweet();
            tweet.Body = "@test\r\nhello";
        }

        [TestMethod]
        public void TweetInvalidHandle()
        {
            Tweet tweet = new Tweet();
            Assert.ThrowsException<Exception>(() => tweet.Body = "test\r\nhello");
        }

        [TestMethod]
        public void TweetHandleTooLong()
        {
            Tweet tweet = new Tweet();
            Assert.ThrowsException<Exception>(() => tweet.Body = "@testtesttesttestes\r\nhello");
        }

        [TestMethod]
        public void BodyTooLong()
        {
            Tweet tweet = new Tweet();
            Assert.ThrowsException<Exception>(() => tweet.Body = "+434 2727 2722\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum rutrum sodales. Nullam mattis fermentum libero, non volutpat..");
        }

        [TestMethod]
        public void AbbreviationMatched()
        {
            Tweet tweet = new Tweet();
            tweet.Body = "@test\r\nLOL";
            Assert.AreEqual(tweet.Body, "@test LOL <Laughing out loud>");
        }

       



    }
}
