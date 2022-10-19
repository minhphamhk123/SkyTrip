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
        static string api_key = "api_key=92q8cw5k6SWV3BImSmJDgcMc5w7aWdeUxwZHHHgZ";
        Apodcheck AC = new Apodcheck();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        public static async Task soso()
        {
            using var client = new ApodClient("92q8cw5k6SWV3BImSmJDgcMc5w7aWdeUxwZHHHgZ");
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
        }
        private void Click_Test(object sender, RoutedEventArgs e)
        {
            nut.Content = "fuck";
            soso();
        }
    }
}
