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
using BeyondLine.Apod;

namespace BeyondLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string api_key = "92q8cw5k6SWV3BImSmJDgcMc5w7aWdeUxwZHHHgZ";
        Apodcheck AC = new Apodcheck();
        Picture_of_day pod = new Picture_of_day();

        public MainWindow()
        {
            InitializeComponent();
            SetDateInCorner();
        }

        private void SetDateInCorner()
        {
            if (DateTime.Today.Day < 10)
            {
                day.Content = "0" + DateTime.Today.Day.ToString() + ".";
            }
            else
                day.Content = DateTime.Today.Day.ToString() + ".";
            if (DateTime.Today.Month < 10)
                month.Content = "0" + DateTime.Today.Month.ToString() + ".";
            else
                month.Content = DateTime.Today.Month.ToString() + ".";
            year.Content = DateTime.Today.Year.ToString();
        }
        /*public static async Task soso()
        {
            using var client = new ApodClient(api_key);
            var response = await client.FetchApodAsync();

            if (response.StatusCode != ApodStatusCode.OK)
            {
                Console.WriteLine(response.Error.ErrorCode);
                Console.WriteLine(response.Error.ErrorMessage);
                return;
            }

            var apod = response.Content;
            Console.WriteLine(apod.Title);
            Console.WriteLine(apod.ContentUrl);
            Console.WriteLine(apod.Explanation);

            foreach (var a in response.AllContent)
            {
                var formattedDate = apod.Date.ToString("MMMM d, yyyy");
                Console.WriteLine($"{formattedDate}: \"{apod.Title}\".");
            }
            //client.Dispose();
        }*/



        private void Test_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pod.Close();
            if (pod.Check_button == 1)
            {
                var obj = pod.Content;
                pod.Content = null;
                Showmake.Children.Clear();
                Showmake.Children.Add(obj as UIElement); 
            }
        }

        private void Close_click(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
