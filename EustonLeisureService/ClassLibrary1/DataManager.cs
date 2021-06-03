using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Business;

/**
 * A class that contains the methods that makes the data from our BookTrain and AddTrain methods persistent. 
 * 
 * @author aaron.campbell
 * 
 * date last edited - 25/10/1
 * */

namespace Data
{
    /**
     *Construct a public DataManager class. This class contains the addMessage methods and make data persistent. 
     * 
     * @param messageList - a list of Messages, used when the user adds a Message to the system.
     * */

    public class DataManager
    {
        [STAThread]
        static void Main()
        {
        }

        //The list containing all messages added to the system. 
        public List<Message> messageList = new List<Message>();

        /**
        *addSMS - this event occurs when the users adds an SMS from the msgForm window. This method takes in the parameters
        *         passed in by the user and adds them to the list of messages.
        *         
        * */
        public void addSMS(SMS newSMS)
        {
            messageList.Add(new SMS(
                newSMS.MessageType,
                newSMS.Header,
                newSMS.Body));
        }

        /**
        *addEmail - this event occurs when the users adds an Email from the msgForm window. This method takes in the parameters
        *         passed in by the user and adds them to the list of messages.
        *         
        * */
        public void addEmail(Email newEmail)
        {
            messageList.Add(new Email(
                newEmail.MessageType,
                newEmail.Header,
                newEmail.Body));
        }

        /**
        *addTweet - this event occurs when the users adds an Tweet from the msgForm window. This method takes in the parameters
        *         passed in by the user and adds them to the list of messages.
        *         
        * */
        public void addTweet(Tweet newTweet)
        {
            messageList.Add(new Tweet(
                newTweet.MessageType,
                newTweet.Header,
                newTweet.Body));
        }

    }
}
