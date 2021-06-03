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
using Business;


namespace EustonLeisureService
{
    /// <summary>
    /// Interaction logic for msgForm.xaml
    /// </summary>
    public partial class msgForm : Window
    {

        public List<Message> messageList = new List<Message>();

        private Message message = new Message();

        public msgForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            string msgHeader = headerBox.Text;
            string msgBody = bodyBox.Text;

            processedMsgHeader.Text = msgHeader;
            processedMsgBody.Text = msgBody;




        }
    }
}
