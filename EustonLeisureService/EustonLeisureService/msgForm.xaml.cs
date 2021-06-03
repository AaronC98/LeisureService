using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Business;
using Newtonsoft.Json;
using Data;

/**
 * A class containing the code related to the Add Message form.  
 * 
 * @author aaron.campbell
 * 
 * date last edited - 25/10/19
 * 
 * */

namespace EustonLeisureService
{

    /**
   *Construct a Window class. This is the class related to adding messages. 
   * 
   * @param msgHeader - a string that will contain the message header.
   * @param msgBody - a string that will contain the message body.
   * @param messageList - a List containing all of the messages added to the system.
   * @param dataManager - a private instance of the class DataManager.
   * @param Message - a private instance of the class Message.
   * @param newSMS
   * */

    public partial class msgForm : Window
    {

        public string msgHeader;
        public string msgBody;

        public List<Message> messageList = new List<Message>();

        private DataManager dataManager = new DataManager();
        private Message message = new Message();

        public msgForm()
        {
            InitializeComponent();
        }

        /**
        *backBtn_Click - simple onClick that navigates back to the main window. 
        * 
        * */
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        /**
        *addBtn_Click - this event occurs when the user clicks the addBtn. This event will take in the values of the textboxes and 
        * write them to their respective lists.
        * 
        * */
        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            //Stores the header textbox text inside the msgHeader variable
            msgHeader = headerBox.Text;
            //Stores the body textbox text inside the msgBody variable
            msgBody = bodyBox.Text;

            //Gets the first char of the message header
            char msgType = msgHeader[0];

            try
            {
                //If the first letter was 'S'
                if (msgType == 'S')
                {
                    //Construct a new SMS object.
                    SMS newSMS = new SMS();

                    //Set the values of the new object to the values of the textboxes
                    newSMS.MessageType = "SMS";
                    newSMS.Header = headerBox.Text;
                    newSMS.Body = bodyBox.Text;

                    //Pass the new oject into the addSMS() method in the DataManager class
                    dataManager.addSMS(newSMS);
                    MessageBox.Show("SMS added.");
                    
                    //Set the values of the 'last added' textboxes to the values entered by the user. 
                    processedMsgType.Text = "SMS";
                    processedMsgHeader.Text = headerBox.Text;
                    processedMsgBody.Text = bodyBox.Text;

                    //Pass the new object to the writeList() method along with the messageList
                    writeList(newSMS, messageList);
                }
                //If the first letter was 'E'
                else if (msgType == 'E')
                {

                    Email newEmail = new Email();

                    newEmail.MessageType = "Email";
                    newEmail.Header = headerBox.Text;
                    newEmail.Body = bodyBox.Text;

                    dataManager.addEmail(newEmail);
                    MessageBox.Show("Email added.");

                    processedMsgType.Text = "Email";
                    processedMsgHeader.Text = headerBox.Text;
                    processedMsgBody.Text = bodyBox.Text;

                    writeList(newEmail, messageList);
                }
                //If the first letter was 'E'
                else if (msgType == 'T')
                {
                    Tweet newTweet = new Tweet();

                    newTweet.MessageType = "Tweet";
                    newTweet.Header = headerBox.Text;
                    newTweet.Body = bodyBox.Text;

                    dataManager.addTweet(newTweet);
                    MessageBox.Show("Tweet added.");

                    processedMsgType.Text = "Tweet";
                    processedMsgHeader.Text = headerBox.Text;
                    processedMsgBody.Text = bodyBox.Text;

                    writeList(newTweet, messageList);
                }
                //Make the textboxes blank
                headerBox.Text = "";
                bodyBox.Text = "";
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }

        /**
       *writeList - Deserialies the JSON list from file, adds the new object and then re-serialises and writes the list back to file.
       *         
       * */

        public void writeList(Message message, List<Message> messageList)
        {
            //Sets file to the file location of the message list
            string file = @"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\message.json";
            //Sets json to the text inside of the file
            string json = File.ReadAllText(file);
            //Converts the values inside json to a List of Messages using Newtonsoft.Json's DeserializeObject method
            messageList = JsonConvert.DeserializeObject<List<Message>>(json);
            //Adds the new message to the List
            messageList.Add(message);
            //Serialises the new List, with the new message.
            var convertedJson = JsonConvert.SerializeObject(messageList, Formatting.Indented);
            //Overrites the file with the new list.
            File.WriteAllText(file, convertedJson);
        }

        /**
        *finishBtn_Click - simple onClick that navigates to the finished screen.
        * 
        * */
        private void finishBtn_Click(object sender, RoutedEventArgs e)
        {
            FinishedScreen f = new FinishedScreen();
            f.Show();
            this.Close();
        }

        /**
        *viewBtn_Click - simple onClick that navigates to the view messages screen. 
        * 
        * */
        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewMessages vm = new ViewMessages();
            vm.Show();
            this.Close();
        }
    }
}

