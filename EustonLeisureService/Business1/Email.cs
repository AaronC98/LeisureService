using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Globalization;

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
    *Construct an Email class, a subclass of Message.
    * 
    * */

    public class Email : Message
    {
        
        //A list of strings containing the significant incident reports recognised by the system. 
        public List<string> sirList = new List<string>();

        private string messageType;
        private string header;
        private string body;

        Regex idRegex = new Regex(@"[E]\d{9}");
        Regex emailRegex = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
        Regex subjectRegex = new Regex(@"^[ a-zA-Z]{1,20}$");
        Regex messageRegex = new Regex(@"^[ a-zA-Z./]{1,1028}$");
        Regex urlRegex = new Regex(@"[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&\\=]*)");
        Regex sirSubjectRegex = new Regex(@"^[S][I][R][ ][0-3]?[0-9].[0-3]?[0-9].(?:[0-9])?[0-9]{2}$");
        Regex codeRegex = new Regex(@"^[0-9]{2}[-][0-9]{3}[-][0-9]{2}$");

        public List<string> quarantineList = new List<string>();

        public Email(string MessageType, string Header, string Body)
        {
            messageType = MessageType;
            header = Header;
            body = Body;
        }

        public Email()
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
      * Get the Email's Header. Check that the type meets the requirements i.e. not blank, in the correct regex format.
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
                    throw new Exception("No message type recieved.");
                }
                //If its length is less than 10.
                else if (value.Length > 10)
                {
                    throw new Exception("Message ID too long");
                }
                //If its first character isn't 'E'.
                else if (value[0] != 'E')
                {
                    throw new Exception("Invalid message ID. Make sure the first character of your ID is E (for an Email).");
                }
                //If it doesn't match the regex i.e. E followed by 9 numbers.
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
        * Get the Email's Body. Validate the body by splitting the string and validating each individual part.
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
                //Split the value passed from the form by newline characters, as the user enters a newline for each item in the body. 
                string[] split = value.Split('\r', '\n');
                //Initialise a string called emailAdddress as the sender of the email. 
                string emailAddress = split[0];
                //Initalise a string as the subject.
                string subject = split[2];
                string message;
                //Take in the first three letters of the subject to check 
                string emailType = subject.Substring(0,3);
                if (value == "")
                {
                    throw new Exception("No body recieved.");
                }
                //If the first three letters of the subject are SIR, validate it as a significant incident report. 
                if (emailType == "SIR")
                {
                    //The SIR's code i.e. 11-111-11
                    string code = split[4];
                    //The SIR's nature of incident
                    string nature = split[6];
                    //The SIR's body.
                    string subjectMessage = split[8];

                    //An array of strings containing the list of acceptable natures of incident.
                    string[] natureOfIncident = new string[11] { "Theft of Properties", "Staff Attack", "Device Damage", "Raid", "Customer Attack", "Staff Abuse", "Bomb Threat", "Terrorism", "Suspicious Incident", "Sport Injury", "Personal Info Leak" };

                    //If the email address doesn't match the email regex.
                    if (!emailRegex.IsMatch(emailAddress))
                    {
                        throw new Exception("Invalid email address. Please ensure you have entered a standard email address i.e. example@email.com");
                    }
                    //If the subject doesn't match the subject regex.
                    if (!sirSubjectRegex.IsMatch(subject))
                    {
                        throw new Exception("Invalid subject i.e. SIR 06/03/2019");
                    }
                    //If the code doesn't match the code regex.
                    else if (!codeRegex.IsMatch(code))
                    {
                        throw new Exception("Invalid sport centre code i.e. 11-111-11");
                    }
                    //If the nature isn't contained in the array.
                    else if (!natureOfIncident.Contains(nature))
                    {
                        throw new Exception("Invalid nature of incident. Please make sure your nature of incident is in the list.");
                    }
                    //If the message doesn't match the regex i.e. is greater than 1028 characters.
                    else if (!messageRegex.IsMatch(subjectMessage))
                    {
                        throw new Exception("Invalid message text. Please ensure it is less than 1028 characters.");
                    }

                    //Split the body to get every word.
                    string[] messageSplit = subjectMessage.Split(' ');

                    //For each word
                    foreach (string word in messageSplit)
                    {
                        //If the word matches the URL regex i.e. is a URL
                        if (urlRegex.IsMatch(word))
                        {
                            //Add the word to the quarantine list.
                            quarantineList.Add(word);
                            //Replace the URL with <URL Quarantined>
                            subjectMessage = subjectMessage.Replace(word, "<URL Quarantined>");
                        }
                    }
                    //Set the message type to SIR
                    MessageType = "Significant Incident Report";

                    string sir = code + ", " + nature;
                    
                    //Write the SIR to sir.txt
                    System.IO.File.AppendAllText(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\sir.txt", sir + Environment.NewLine);

                    //Write the quarantined URL to quarantine.txt
                    System.IO.File.AppendAllLines(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\quarantine.txt", quarantineList);

                    //Add all the split values together and set this to the value of body.
                    message = emailAddress + " " + subject + " " + code + " " + nature + " " + subjectMessage;
                    value = message;
                    body = value;

                }
                //If the email is a standard email
                else {
                    //The message body
                    string messageText = split[4];

                    if (!emailRegex.IsMatch(emailAddress))
                    {
                        throw new Exception("Invalid email address.");

                    }
                    //If the subject doesn't match the standard subject regex.
                    else if (!subjectRegex.IsMatch(subject))
                    {
                        throw new Exception("Invalid subject. Please ensure it is less than 20 characters.");
                    }
                    else if (!messageRegex.IsMatch(messageText))
                    {
                        throw new Exception("Invalid message text. Please ensure it is less than 1028 characters.");
                    }

                    string[] messageSplit = messageText.Split(' ');

                    foreach (string word in messageSplit)
                    {
                        if (urlRegex.IsMatch(word))
                        {
                            quarantineList.Add(word);
                            messageText = messageText.Replace(word, "<URL Quarantined>");
                        }
                    }
                    MessageType = "Standard Email";
                    System.IO.File.AppendAllLines(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\quarantine.txt", quarantineList);
                    message = emailAddress + " " + subject + " " + messageText;
                    value = message;
                    body = value;
                }
            }
        }
    }
}




