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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;


namespace wpf08_toyproject_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        private HttpClient httpClient;

        public MainWindow()
        {
            InitializeComponent();

            httpClient = new HttpClient();
            LoadDataFromOpenAPI();
        }



        private void DataList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}