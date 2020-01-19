using System.Windows;
using IT_Department_Management.View;

namespace IT_Department_Management
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCurrentTasks_Click(object sender, RoutedEventArgs e)
        {
            //RecipientList recipientList = new RecipientList();
            //recipientList.Owner = this;
            //recipientList.ShowDialog();
        }

        private void btnComputers_Click(object sender, RoutedEventArgs e)
        {
            ComputersList computersList = new ComputersList();
            computersList.Owner = this;
            computersList.ShowDialog();
        }
    }
}
