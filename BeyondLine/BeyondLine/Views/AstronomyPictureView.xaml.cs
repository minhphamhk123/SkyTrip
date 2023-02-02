using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Extensions.DependencyInjection;
using NasaApiExplorer.ViewModels;

namespace NasaApiExplorer.Views
{
    public sealed partial class AstronomyPictureView : Page
    {
        public AstronomyPictureViewModel ViewModel => (AstronomyPictureViewModel)DataContext;

        public AstronomyPictureView()
        {
            this.InitializeComponent();
            Dayapod.MaxDate = DateTime.Today;

            this.DataContext =
                App.Current.ServiceHost.Services.GetRequiredService<AstronomyPictureViewModel>();           
        }
    }
}