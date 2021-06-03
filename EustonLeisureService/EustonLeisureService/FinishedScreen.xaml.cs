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
using Data;

/**
 * A class containing the code related to the Finished screen form.  
 * 
 * @author aaron.campbell
 * 
 * date last edited - 25/10/19
 * 
 * */

namespace EustonLeisureService
{
    /// <summary>
    /// Interaction logic for FinishedScreen.xaml
    /// </summary>
    public partial class FinishedScreen : Window
    {

        public FinishedScreen()
        {
            InitializeComponent();
            displayLists();
        }

       /**
       *displayLists - reads the individual files and displays them in their corresponding textboxes.
       * 
       * */

        private void displayLists()
        {
            //Reads the mentions.txt file to a List
            List<string> mentionsList = File.ReadAllLines(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\mentions.txt").ToList();
            //For each item in the list
            foreach(var ment in mentionsList)
            {
                //Add to the mention listbox
                mentionBox.Items.Add(ment);
            }

            //Reads the hashtags.txt file to a List
            List<string> hashtagList = File.ReadAllLines(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\hashtags.txt").ToList();
            //Uses LINQ to order the hashtag list by count i.e. its number of occurrences in the list and stores in a new variable called wordCount
            var wordCount = hashtagList.GroupBy(i => i).OrderByDescending(group => group.Count());
            //For each item in wordCount
            foreach (var word in wordCount)
            {
                //Adds the item's key i.e. it's value and it's count to the hashtag listbox
                hashtagBox.Items.Add(word.Key + " (Count: " + word.Count() + ")");
            }

            //For each line in the sir.txt file
            foreach (var line in File.ReadLines(@"D:\\Uni Work\\Year 3\\Software Engineering\\Coursework\\EustonLeisureService\\sir.txt"))
            {
                //Split the file by newline and store the values either side of the newline as an array of strings
                string[] sirs = line.Split('\n');
                //For each item in the array
                foreach (var sir in sirs)
                {
                    //Add the items to the SIR listbox
                    seriousBox.Items.Add(sir);
                }
            }
        }

        /**
        *backBtn_Click - simple onClick that navigates back to the add message form.
        * 
        * */

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            msgForm m = new msgForm();
            m.Show();
            this.Close();
        }

        /**
        *closeBtn_Click - simple onClick that closes the window.
        * */

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
