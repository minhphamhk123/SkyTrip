using Apod;
using BeyondLine.Apod;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BeyondLine
{
    /// <summary>
    /// Interaction logic for Picture_of_day.xaml
    /// </summary>
    public partial class Picture_of_day : Window
    {
        Data dt = new Data();
        public int Check_button = 0;
        string SetDate;
        string OldDate;
        public Picture_of_day()
        {
            InitializeComponent();
            DatePick.SelectedDate = DateTime.Today;
            OldDate = DatePick.SelectedDate.ToString();
        }

        [SuppressUnmanagedCodeSecurity, SecurityCritical, DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SystemParametersInfo(int nAction, int nParam, string value, int ignore);
        public static async Task GetApod(Data dt, DateTime date)
        {
            if (date != null)
            {
                using var client = new ApodClient("92q8cw5k6SWV3BImSmJDgcMc5w7aWdeUxwZHHHgZ");
                var response = await client.FetchApodAsync(date);

                if (response.StatusCode != ApodStatusCode.OK)
                {
                    Console.WriteLine(response.Error.ErrorCode);
                    Console.WriteLine(response.Error.ErrorMessage);
                    return;
                }
                var apod = response.Content;
                dt.Title = apod.Title;
                dt.date = apod.Date;
                dt.OnlPicture = apod.ContentUrl;
                dt.OnlPictureHD = apod.ContentUrlHD;
                dt.Decripsion = apod.Explanation;
                dt.TypeMedia = apod.MediaType;

                /*foreach (var a in response.AllContent)
                {
                    var formattedDate = apod.Date.ToString("MMMM d, yyyy");
                    Console.WriteLine($"{formattedDate}: \"{apod.Title}\".");
                }*/
                //client.Dispose(); 
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            WaitLoad_Progressbar.Value = 0;
            var progress = new Progress<int>(percent =>
            {
                WaitLoad_Progressbar.Value = percent;
            });
            SetWindowInfor(progress);
        }

        async void SetWindowInfor(IProgress<int> progress)
        {

            if (OldDate != "")
            {
                await GetApod(dt, DatePick.SelectedDate.Value.Date);

                Title_picture.Content = dt.Title;
                DatePick.SelectedDate = dt.date;
                Decription.Text = dt.Decripsion;
                progress.Report(50);

                if (dt.TypeMedia == MediaType.Image)
                {
                    Picture.Source = null;
                    var fullFilePath = dt.OnlPicture;

                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
                    bitmap.EndInit();

                    testImage.Source = bitmap; 
                }
                else
                {
                    testImage.Source = null;
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(dt.OnlPicture, Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + 1 + "mp4");
                    }
                    Picture.Source = new Uri(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + 1 + "mp4"); 
                }
                progress.Report(0); 
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Check_button = 1;
        }

        private void DatePick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            WaitLoad_Progressbar.Value = 0;
            var progress = new Progress<int>(percent =>
            {
                WaitLoad_Progressbar.Value = percent;
            });
            SetWindowInfor(progress);
            OldDate = DatePick.SelectedDate.Value.Date.ToString();
        }

        private void Wallpaper_Click(object sender, RoutedEventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                if (dt.TypeMedia == MediaType.Image)
                {
                    client.DownloadFile(dt.OnlPictureHD, Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + 1 + "jpg");
                    SystemParametersInfo(20, 0, Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + 1 + "jpg", 0);
                }  
            }
        }
    }
}
