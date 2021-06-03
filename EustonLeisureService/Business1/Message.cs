using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/**
 * A simple class encapsulating Message details. 
 * 
 * @author aaron.campbell
 * 
 * date last edited - 01/11/19
 * 
 * */

namespace Business
{

    /**
    *Construct a Message class.
    * 
    * messageType - the type of message - either SMS, Tweet or Email. 
    * header - the message header i.e. the message ID.
    * body - the message body
    * */

    public class Message
    {

        private string messageType;
        private string header;
        private string body;

        //Matches a letter followed by any 9 number
        Regex idRegex = new Regex(@"[A-Z]\d{9}");

        /**
      * A public constructor which makes the private variables inside the Message class accessible from the Data and Presentation layers. 
      */

        public Message()
        {
        }

        /**
       * Get the Message's ID. Check that the type meets the requirements i.e. not blank.
       * 
       * @return the value of the type
       */


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
      * Get the Message's Header. Check that the type meets the requirements i.e. not blank, in the correct regex format.
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
                else if (value[0] != 'S' && value[0] != 'E' && value[0] != 'T')
                {
                    throw new Exception("Invalid message ID. Make sure the first character of your ID is S (for an SMS), E (for an Email) or T (for a Tweet).");
                }
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
         * Get the Message's Body. Check that the type meets the requirements i.e. not blank.
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
                if (value == "")
                {
                    throw new Exception("No message type recieved.");
                }
                {
                    body = value;
                }
            }
        }

    }

}

