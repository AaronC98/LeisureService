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
   *Construct a Tweet class, a subclass of Message.
   * 
   * */

    public class Tweet : Message
    {
        private string messageType;
        private string header;
        private string body;

        //A list of strings containing the hashtags.
        public List<string> hashtagList = new List<string>();
        //A list of strings containing the mentions.
        public List<string> mentionsList = new List<string>();

        Regex idRegex = new Regex(@"[T]\d{9}");
        Regex twitterRegex = new Regex(@"^[@](\w){1,15}$");
        Regex messageRegex = new Regex(@"^[ a-zA-Z#@0-9]{1,140}$");
        Regex hashtagRegex = new Regex(@"\B(\#[a-zA-Z]+\b)(?!;)");

        public Tweet(string MessageType, string Header, string Body)
        {
            messageType = MessageType;
            header = Header;
            body = Body;
        }

        public Tweet()
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
      * Get the Tweet's Header. Check that the type meets the requirements i.e. not blank, in the correct regex format.
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
                if (value == "")
                {
                    throw new Exception("No message ID recieved.");
                }
                //If its length is less than 10.
                else if (value.Length > 10)
                {
                    throw new Exception("Message ID too long");
                }
                //If its first character isn't 'T'.
                else if (value[0] != 'T')
                {
                    throw new Exception("Invalid message ID. Make sure the first character of your ID is S (for an SMS), E (for an Email) or T (for a Tweet).");
                }
                //If it doesn't match the regex i.e. T followed by 9 numbers.
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
        * Get the Tweet's Body. Validate the body by splitting the string and validating each individual part.
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
                //Initialise a string called twitterUser as the sender of the tweet. 
                string twitterUser = split[0];
                //Set the rest of the body to the message body.
                string messageText = value.Split('\n')[1];
                string message;

                //If its value is blank.
                if (value == "")
                {
                    throw new Exception("No message type recieved.");
                }
                //If the twitter handle doesn't match the regex.
                else if (!twitterRegex.IsMatch(twitterUser))
                {
                    throw new Exception("Invalid sender. Please make sure it is a valid Twitter handle i.e. @example");
                }
                //If the body doesn't match the regex i.e. 140 characters
                else if (!messageRegex.IsMatch(messageText))
                {
                    throw new Exception("Invalid message. Please make sure it is 140 characters or less.");
                }
                //Get every word using string.split
                string[] messageSplit = messageText.Split(' ');

                //For each item in textspeak
                foreach (var entry in textspeak)
                {
                    //If the value occurs, replace it with the key and its value expanded in <> format.
                    messageText = messageText.Replace(entry.Key, entry.Key + " <" + entry.Value + ">");
                }

                //For the length of the array i.e. words in the body
                for (int i = 0; i < messageSplit.Length; i++)
                {
                    //If a word matches the hashtag regex
                    if (hashtagRegex.IsMatch(messageSplit[i]))
                    {
                        //Add it to the hashtag list.
                        hashtagList.Add(messageSplit[i]);
                    }
                }

                
                for (int i = 0; i < messageSplit.Length; i++)
                {
                    //If a word's first char is an @ symbol
                    if (messageSplit[i][0] == '@')
                    {
                        //Add it to the mentions list.
                        mentionsList.Add(messageSplit[i]);
                    }
                }
                //Write the hashtag list to hashtags.txt
                System.IO.File.AppendAllLines(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\hashtags.txt", hashtagList);
                //Write the mentions list to mentions.txt
                System.IO.File.AppendAllLines(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\mentions.txt", mentionsList);
                message = twitterUser + " " + messageText;
                value = message;
                body = value;
            }
        }
    }
}




