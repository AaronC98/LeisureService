using System.Windows;



namespace EustonLeisureService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void msgBtn_Click(object sender, RoutedEventArgs e)
        {
            msgForm m = new msgForm();
            m.Show();
            this.Close();
        }


        private void inputBtn_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
