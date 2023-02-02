using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NasaApiExplorer.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            SetDateInCorner();
        }

        private void SetDateInCorner()
        {
            if (DateTime.Today.Day < 10)
            {
                day.Text = "0" + DateTime.Today.Day.ToString() + ".";
            }
            else
                day.Text = DateTime.Today.Day.ToString() + ".";
            if (DateTime.Today.Month < 10)
                month.Text = "0" + DateTime.Today.Month.ToString() + ".";
            else
                month.Text = DateTime.Today.Month.ToString() + ".";
            year.Text = DateTime.Today.Year.ToString();
        }
    }
}
