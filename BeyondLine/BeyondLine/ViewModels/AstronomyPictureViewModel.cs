using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using NasaApiExplorer.Services;
using NasaApiExplorer.Services.NasaApis;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.System.UserProfile;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace NasaApiExplorer.ViewModels
{
    public class AstronomyPictureViewModel : Base.Observable
    {
        private readonly INasaApiService _nasaApiService;
        private AstronomyPictureOfTheDay _astronomyPictureOfTheDay;
        private bool _isLoading;
        protected DateTimeOffset? _selectedDate;
        protected readonly IFileDownloadService _fileDownloadService;

        public ICommand LoadApodCommand { get; set; }
        public ICommand UpdateDateCommand { get; set; }
        public ICommand SetWallpaperCommand { get; set; }
        public ICommand DownloadPhotosCommand { get; set; }

        public AstronomyPictureViewModel(INasaApiService nasaApiService, IFileDownloadService fileDownloadService)
        {
            _nasaApiService = nasaApiService;
            _fileDownloadService = fileDownloadService;

            LoadApodCommand =
                new AsyncRelayCommand(LoadAstronomyPictureOfTheDayAsync, () => true);
            UpdateDateCommand =
               new Base.RelayCommand<DateTimeOffset?>(UpdateSelectedDate);
            SetWallpaperCommand =
                new AsyncRelayCommand(SetWallPaperClickAsync);
            DownloadPhotosCommand =
                new AsyncRelayCommand(DownloadPhotos);
        }

        [SuppressUnmanagedCodeSecurity, SecurityCritical, DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SystemParametersInfo(int nAction, int nParam, string value, int ignore);

        public AstronomyPictureOfTheDay AstronomyPictureOfTheDay
        {
            get => _astronomyPictureOfTheDay;
            set => SetProperty(ref _astronomyPictureOfTheDay, value);
        }

        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        public DateTimeOffset? SelectedDate
        {
            get => _selectedDate;
            set
            {
                _selectedDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Downloads rover photos for the selected date in a location chosen 
        /// through a folder picker.
        /// </summary>
        /// <returns></returns>
        public async Task DownloadPhotos()
        {
            // Retrieve urls from source url property of the photo objects
            string urls = _astronomyPictureOfTheDay.HdUrl;

            try
            {
                await _fileDownloadService.DownloadFileAsync(urls);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateSelectedDate(DateTimeOffset? date) => SelectedDate = date;

        public async Task SetWallPaperClickAsync()
        {

            /*string urls = _astronomyPictureOfTheDay.HdUrl;
            string test = "";
            bool success = false;
            try
            {
                test = await _fileDownloadService.DownloadFileAsync(urls,test);
                if (UserProfilePersonalizationSettings.IsSupported())
                {
                    StorageFile file = await StorageFile.GetFileFromPathAsync(test);
                    UserProfilePersonalizationSettings profileSettings = UserProfilePersonalizationSettings.Current;
                    success = await profileSettings.TrySetWallpaperImageAsync(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            FileOpenPicker picker = new FileOpenPicker();
            picker.FileTypeFilter.Add("*");
            StorageFile file = await picker.PickSingleFileAsync();

            // copy file to the local folder  
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile newfile = await file.CopyAsync(folder, "test.png", NameCollisionOption.ReplaceExisting);

            if (file != null)
            {
                if (UserProfilePersonalizationSettings.IsSupported())
                {

                    UserProfilePersonalizationSettings profileSettings = UserProfilePersonalizationSettings.Current;
                    bool success = await profileSettings.TrySetWallpaperImageAsync(newfile);
                }
            }
        }

        /*async Task<bool> SetWallpaperAsync(string localAppDataFileName)
        {
            bool success = false;
            if (UserProfilePersonalizationSettings.IsSupported())
            {
                var uri = new Uri("ms-appx:///Local/" + localAppDataFileName);
                StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(uri);
                UserProfilePersonalizationSettings profileSettings = UserProfilePersonalizationSettings.Current;
                success = await profileSettings.TrySetWallpaperImageAsync(file);
            }
        }*/

        /// <summary>
        /// Retrieves the Astronomy Picture of the Day from the picture service.  
        /// </summary>
        /// <returns></returns>
        public async Task LoadAstronomyPictureOfTheDayAsync()
        {
            IsLoading = true;

            try
            {
                if (_selectedDate != null)
                {
                    AstronomyPictureOfTheDay = await _nasaApiService.Apod.GetAstronomyPictureOfTheDayAsync("&date="+_selectedDate.Value.Year.ToString() + "-" + _selectedDate.Value.Month.ToString() + "-" + _selectedDate.Value.Day); 
                }
                else
                    AstronomyPictureOfTheDay = await _nasaApiService.Apod.GetAstronomyPictureOfTheDayAsync("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}