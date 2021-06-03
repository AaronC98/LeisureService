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
using Data;
using Business;
using Newtonsoft.Json;

/**
 * A class containing the code related to the View Messages form.  
 * 
 * @author aaron.campbell
 * 
 * date last edited - 25/10/19
 * 
 * */

namespace EustonLeisureService
{
   
    public partial class ViewMessages : Window
    {
        public List<Message> messageList = new List<Message>();

        public ViewMessages()
        {
            InitializeComponent();
            Load();
        }

        /**
        *backBtn_Click - simple onClick that navigates back to the main window. 
        * 
        * */
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            msgForm m = new msgForm();
            m.Show();
            this.Close();
        }

        /**
        *Load() - loads in the message list and displays in the left textbox. 
        * 
        * */
        private void Load()
        {
            //Stores in the file in a string called file
            string file = @"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\message.json";
            //Stores the contents of the file in json
            string json = File.ReadAllText(file);
            //Deserialises the file to a List
            messageList = JsonConvert.DeserializeObject<List<Message>>(json);

            //For each item in the list
            foreach (var message in messageList)
            {
                //Add its header to the box
                messageBox.Items.Add(message.Header);
            }
        }

        /**
        *messageBox_SelectionChanged - occurs when the user clicks on one of the items in the listbox
        * 
        * */
        private void messageBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Stores the user's selected item as a string
            string messageId = messageBox.SelectedItem.ToString();
            //Passes the string to the findMessage() method
            findMessage(messageId);
        }

        /**
        *findMessage - a method that finds a message when a header is passed to it
        * 
        * */
        private void findMessage(string messageId)
        {
            //Stores the result of a List.Find method on the list of messages, looks for a Message that contains the messageId selected by the user
            Message result = messageList.Find(x => x.Header.Contains(messageId));
            //Sets the text boxes to the result's corresponding information.
            processedMsgType.Text = result.MessageType;
            processedMsgHeader.Text = result.Header;
            processedMsgBody.Text = result.Body;
        }


    }
}
