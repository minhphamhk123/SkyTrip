using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Apod;
using System.IO;
using System.Web.Script.Serialization;

namespace BeyondLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient client = new HttpClient();
        static string api_key = "api_key=92q8cw5k6SWV3BImSmJDgcMc5w7aWdeUxwZHHHgZ";
        public MainWindow()
        {
            InitializeComponent();
        }
        [SuppressUnmanagedCodeSecurity, SecurityCritical, DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SystemParametersInfo(int nAction, int nParam, string value, int ignore);
        private void Click_Test(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Datepicker.SelectedDate.Value.Year.ToString() + "-" + Datepicker.SelectedDate.Value.Month.ToString() + "-" + Datepicker.SelectedDate.Value.Day.ToString());         
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://api.nasa.gov/planetary/apod?date=2022-10-4&" + api_key);
            var respuesta = req.GetResponse();
            var dataStream = respuesta.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            JavaScriptSerializer j = new JavaScriptSerializer();
            Data model = j.Deserialize<Data>(responseFromServer);
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(model.hdurl), @"D:\Hình ảnh\Thời sinh viên\wallpaper.jpg");
                SystemParametersInfo(20, 0, @"D:\Hình ảnh\Thời sinh viên\wallpaper.jpg", 0);
                this.Close();
                //Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("wallpaper", wallpaper);
            }
        }
}
