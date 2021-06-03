using System.IO;
using System.Windows;
using Data;
using Microsoft.Win32;
using Business;
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
 * A class containing the code related to the Main Window form.  
 * 
 * @author aaron.campbell
 * 
 * date last edited - 25/10/19
 * 
 * */

namespace EustonLeisureService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Message> messageReadList = new List<Message>();
        DataManager dataManager = new DataManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        /**
        *msgBtn_Click - simple onClick that navigates to the add message screen.
        * 
        * */

        private void msgBtn_Click(object sender, RoutedEventArgs e)
        {
            msgForm m = new msgForm();
            m.Show();
            this.Close();
        }

        //private void inputBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog browseFile = new OpenFileDialog();
        //    browseFile.ShowDialog();

        //    string FileName = browseFile.FileName;

        //    readFile(FileName);

        //}

        //public void readFile(string fileName)
        //{
        //    foreach (var line in File.ReadLines(fileName))
        //    {
        //        string[] inputItem = line.Split('\n');
        //        foreach (var item in inputItem)
        //        {
        //            string[] fieldSplit = item.Split(',');
        //            string inputHeader = fieldSplit[1];
        //            string inputBody = fieldSplit[2];

        //            if (fieldSplit[0] == "SMS")
        //            {
        //                SMS newSMS = new SMS();

        //                newSMS.MessageType = "SMS";
        //                newSMS.Header = inputHeader;
        //                newSMS.Body = inputBody;

        //                dataManager.addSMS(newSMS);
        //                writeList(newSMS, messageReadList);
        //            }
        //            else if (fieldSplit[0] == "Tweet")
        //            {
        //                Tweet newTweet = new Tweet();

        //                newTweet.MessageType = "Tweet";
        //                newTweet.Header = inputHeader;
        //                newTweet.Body = inputBody;

        //                dataManager.addTweet(newTweet);
        //                writeList(newTweet, messageReadList);
        //            }
        //            else if (fieldSplit[0] == "Email")
        //            {
        //                Email newEmail = new Email();

        //                newEmail.MessageType = "Email";
        //                newEmail.Header = inputHeader;
        //                newEmail.Body = inputBody;

        //                dataManager.addEmail(newEmail);
        //                writeList(newEmail, messageReadList);
        //            }
        //        }
        //    }
        //}

        //public void writeList(Message message, List<Message> messageReadList)
        //{
        //    string file = @"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\inputmessages.json";
        //    string json = File.ReadAllText(file);
        //    messageReadList = JsonConvert.DeserializeObject<List<Message>>(json);
        //    messageReadList.Add(message);
        //    var convertedJson = JsonConvert.SerializeObject(messageReadList, Formatting.Indented);
        //    File.WriteAllText(file, convertedJson);

        //}
    }
}
