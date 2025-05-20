using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ServiceCenter.Pages;

namespace ServiceCenter
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

        private void MainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainTabControl.SelectedItem is TabItem selectedTab)
            {
                switch (selectedTab.Tag.ToString())
                {
                    case "Home":
                        MainFrame.Navigate(new HomePage());
                        break;

                    case "Orders":
                        MainFrame.Navigate(new OrdersPage());
                        break;

                    case "Stats":
                        MainFrame.Navigate(new StatsPage());
                        break;

                    case "Clients":
                        MainFrame.Navigate(new ClientsPage());
                        break;

                    case "Store":
                        MainFrame.Navigate(new StorePage());
                        break;
                }
            
            }
        }
    }
}