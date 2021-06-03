using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Business;

namespace Data
{
    class DataManager
    {
        [STAThread]
        static void Main()
        {
        }

        public List<Message> messageList = new List<Message>();

        public void addMessage(Message newMessage)
        {
            messageList.Add(new Message(
                newMessage.MessageType,
                newMessage.Header,
                newMessage.Body));

            var filepath = "D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\Messages.csv";
            {
                File.AppendAllText(filepath,
                    newMessage.MessageType
                    + "," + newMessage.Header
                    + "," + newMessage.Body
                    + Environment.NewLine);
            }
        }

    }
}
