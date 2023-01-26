using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BeyondLine.API
{
    public class Api
    {
        private string Key { get; set; }
        private string Region { get; set; }
        public Api(string region)
        {
            Region = region;
            Key = GetKey("Api.txt");
        }
        protected string GetURI(string path)
        {
            return "";
        }
        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
