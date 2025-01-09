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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interface_prototype.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy AdminLogPage.xaml
    /// </summary>
    public partial class AdminLogPage : Page
    {
        public AdminLogPage()
        {
            InitializeComponent();
        }

        private void BtnPowrot_Click(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.MainFrame.Navigate(new Uri("Pages/ChooseUserPage.xaml", UriKind.Relative));
        }
    }
}
