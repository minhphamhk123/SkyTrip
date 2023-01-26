using Apod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BeyondLine
{
    public class Data
    {
        public string Title { get; set; }
        public DateTime date { get; set; }
        public Image picture { get; set; }
        public string OnlPicture { get; set; }
        public string OnlPictureHD { get; set; }
        public string Decripsion { get; set; }
        public MediaType TypeMedia { get; set; }
        public string Copyright { get; set; }
        public Data() { }
        /*public Data(String title, DateTime date, String url, String thongtin)
        {
            this.Title = title;
            this.date = date;
            this.OnlPicture = url;
            this.Decripsion = thongtin;
        }*/
    }
}
