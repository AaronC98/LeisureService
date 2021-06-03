using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/**
 * A subclass of Message, holding the details for each Email added to the system. Note that the variables are identical
 * to the Message class, with the exception of their validation.
 * 
 * @author aaron.campbell
 * 
 * date last edited - 16/11/19
 * 
 * */

namespace Business
{

    /**
    *Construct an SMS class, a subclass of Message.
    * 
    * */

    public class SMS : Message
    {
        private string messageType;
        private string header;
        private string body;

        Regex idRegex = new Regex(@"[S]\d{9}");
        Regex phoneRegex = new Regex(@"^\+((?:9[679]|8[035789]|6[789]|5[90]|42|3[578]|2[1-689])|9[0-58]|8[1246]|6[0-6]|5[1-8]|4[013-9]|3[0-469]|2[70]|7|1)(?:\W*\d){0,13}\d$");
        Regex messageRegex = new Regex(@"^[ a-zA-Z'.]{1,140}$");

        public SMS(string MessageType, string Header, string Body)
        {
            messageType = MessageType;

            header = Header;
            body = Body;
        }

        public SMS()
        {
        }

        public string MessageType
        {
            get
            {
                return messageType;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("No message type recieved.");
                }
                {
                    messageType = value;
                }
            }
        }

      /**
      * Get the SMS' Header. Check that the type meets the requirements i.e. not blank, in the correct regex format.
      * 
      * @return the value of the header
      */

        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                //If the header is blank.
                if (value == "")
                {
                    throw new Exception("No message type recieved.");
                }
                //If its length is less than 10.
                else if (value.Length > 10)
                {
                    throw new Exception("Message ID too long");
                }
                //If its first character isn't 'S'.
                else if (value[0] != 'S')
                {
                    throw new Exception("Invalid message ID. Make sure the first character of your ID is S (for an SMS), E (for an Email) or T (for a Tweet).");
                }
                //If it doesn't match the regex i.e. S followed by 9 numbers.
                else if (!idRegex.IsMatch(value))
                {
                    throw new Exception("Please enter a valid ID i.e. S, E or T followed by 9 numbers.");
                }
                {
                    header = value;
                }
            }
        }

        /**
        * Get the SMS' Body. Validate the body by splitting the string and validating each individual part.
        * 
        * @return the value of the body
         */

        public string Body
        {
            get
            {
                return body;
            }
            set
            {
                //Create a new dictionary
                Dictionary<string, string> textspeak = new Dictionary<string, string>();

                //For each line in the textwords csv file
                foreach (string line in File.ReadAllLines("D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\textwords.csv"))
                {
                    //Split line by comma i.e. key, value
                    string[] keyvalue = line.Split(',');
                    //For every pair of key/value
                    if (keyvalue.Length == 2)
                    {
                        //Add to the dictionary
                        textspeak.Add(keyvalue[0], keyvalue[1]);
                    }
                }
                //Split the value passed from the form by newline characters, as the user enters a newline for each item in the body.
                string[] split = value.Split('\r', '\n');
                //Initialise a string called telNum that will represent the sender of the SMS.
                string telNum = split[0];
                //Set the rest of the body to the message body.
                string messageText = value.Split('\n')[1];
                string message;

                //If its value is blank.
                if (value == "")
                {
                    throw new Exception("No message type recieved.");
                }
                //If the phone number doesn't match the regex. 
                else if (!phoneRegex.IsMatch(telNum))
                {
                    throw new Exception("Please make sure your phone number matches the format of an international phone number.");
                }
                //If the message doesn't match the regex i.e. 140 characters.
                else if (!messageRegex.IsMatch(messageText))
                {
                    throw new Exception("Please make sure your message is less than 140 characters.");
                }

                //Get every word using string.split
                string[] messageSplit = messageText.Split(' ');

                //For each item in textspeak
                foreach (var entry in textspeak)
                {
                    //If the value occurs, replace it with the key and its value expanded in <> format.
                    messageText = messageText.Replace(entry.Key, entry.Key + " <" + entry.Value + ">");
                }

                message = telNum + " " + messageText;
                value = message;
                body = value;
                }
            }
        }
    }